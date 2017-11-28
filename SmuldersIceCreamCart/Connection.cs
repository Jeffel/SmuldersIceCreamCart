using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SmuldersIceCreamCart.Users;

namespace SmuldersIceCreamCart
{
    public enum LoginType
    {
        NONE,
        EMPLOYEE,
        CUSTOMER
    }
    public class Connection
    {
        const string connectionFormat = "Host={0};Username={1};Password={2}";
        private static NpgsqlConnection connection;

        public Connection(string host, string username, string password)
        {
            if (connection == null)
            {
                string connectionString = String.Format(connectionFormat, host, username, password);
                connection = new NpgsqlConnection(connectionString);
                connection.Open();
            }
        }

        ~Connection()
        {
            connection.Close();
        }

        public static LoginType GetLoginType(string email, string password)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT email FROM person WHERE email=@email AND password=@password;", connection);
            cmd.Parameters.Add("email", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Parameters.Add("password", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Prepare();
            cmd.Parameters[0].Value = email;
            cmd.Parameters[1].Value = password;
            var returned = cmd.ExecuteScalar();
            
            if (returned is null)
            {
                return LoginType.NONE;
            }
            cmd = new NpgsqlCommand("SELECT email FROM employee WHERE email=@email;", connection);
            cmd.Parameters.Add("email", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Prepare();
            cmd.Parameters[0].Value = email;
            returned = cmd.ExecuteScalar();
            if (returned is null)
            {
                return LoginType.CUSTOMER;
            } else
            {
                return LoginType.EMPLOYEE;
            }
        }

        public static Employee GetEmployeeFromEmail(string email)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT employee.email, person.first_name, person.last_name, person.phone_number, employee.hours_worked, employee.hourly_wage FROM(employee JOIN person ON employee.email = person.email) WHERE employee.email = @email;", connection);
            cmd.Parameters.Add("email", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Prepare();
            cmd.Parameters[0].Value = email;
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                return null;
            }
            reader.Read();
            Employee employee = new Employee(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetFloat(4), reader.GetFloat(5));
            reader.Close();
            return employee;
        }
        public static Customer GetCustomerFromEmail(string email)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT customer.email, person.first_name, person.last_name, person.phone_number, customer.billing_address_id, address.street_num, address.street_name, address.city, address.state, address.zipcode FROM ((customer JOIN person ON customer.email=person.email) LEFT OUTER JOIN address ON address.id=customer.billing_address_id) WHERE person.email=@email;", connection);
            cmd.Parameters.Add("email", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Prepare();
            cmd.Parameters[0].Value = email;
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                return null;
            }
            reader.Read();
            string[] attributes = new string[9];
            for (int i = 0; i < attributes.Length; i++)
            {
                if (reader.IsDBNull(i))
                {
                    attributes[i] = "";
                }
                else
                {
                    attributes[i] = reader.GetString(i);
                }
            }
            Address address = new Address(true, attributes[4], attributes[5], attributes[6], attributes[7], attributes[8]);
            Customer customer = new Customer(attributes[0], attributes[1], attributes[2], attributes[3], address);
            reader.Close();
            return customer;
        }
        public static void DeleteUser(User user)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM person WHERE email=@email;", connection);
            cmd.Parameters.Add("email", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Prepare();
            cmd.Parameters[0].Value = user.Email;
            cmd.ExecuteNonQuery();
        }

        public static bool UpdatePassword(User user, string current, string newPass)
        {
            LoginType type = GetLoginType(user.Email, current);
            if (type == LoginType.NONE)
            {
                return false;
            }
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE person SET password=@password WHERE email=@email;", connection);
            cmd.Parameters.Add("email", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Parameters.Add("password", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Prepare();
            cmd.Parameters[0].Value = user.Email;
            cmd.Parameters[1].Value = newPass;
            cmd.ExecuteNonQuery();
            return true;
        }

        public static bool CreateUser(string email, string password, string firstName, string lastName, bool isEmployee)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO person (email, password, first_name, last_name) VALUES (@email, @password, @first_name, @last_name) ON CONFLICT DO NOTHING;", connection);
            cmd.Parameters.Add("email", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Parameters.Add("password", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Parameters.Add("first_name", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Parameters.Add("last_name", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Prepare();
            cmd.Parameters[0].Value = email;
            cmd.Parameters[1].Value = password;
            cmd.Parameters[2].Value = firstName;
            cmd.Parameters[3].Value = lastName;
            int changed = cmd.ExecuteNonQuery();
            if (changed == 0)
            {
                return false;
            }

            if (isEmployee)
            {
                cmd = new NpgsqlCommand("INSERT INTO employee (email) VALUES (@email);", connection);
            } else
            {
                cmd = new NpgsqlCommand("INSERT INTO customer (email) VALUES (@email);", connection);
            }
            cmd.Parameters.Add("email", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Prepare();
            cmd.Parameters[0].Value = email;
            cmd.ExecuteNonQuery();
            return true;
        }
    }
}
