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
        NpgsqlConnection connection;

        public Connection(string host, string username, string password)
        {
            string connectionString = String.Format(connectionFormat, host, username, password);
            connection = new NpgsqlConnection(connectionString);
            connection.Open();
        }

        ~Connection()
        {
            connection.Close();
        }

        public LoginType GetLoginType(string email, string password)
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

        public Employee GetEmployeeFromEmail(string email)
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
        public Customer GetCustomerFromEmail(string email)
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
            Address address = new Address(true, reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8));
            Customer customer = new Customer(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), address);
            reader.Close();
            return customer;
        }
    }
}
