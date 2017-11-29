﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SmuldersIceCreamCart.Users;
using SmuldersIceCreamCart.Orders;
using SmuldersIceCreamCart.Menu;

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
            string[] attributes = new String[4];
            for(int i = 0; i < attributes.Length; i++)
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
            Employee employee = new Employee(attributes[0], attributes[1], attributes[2], attributes[3], reader.GetFloat(4), reader.GetFloat(5));
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

        public static bool PlaceOrder(User user, Order order)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO orders (status) VALUES (@status) RETURNS id;", connection);
            cmd.Parameters.Add("status", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Prepare();
            cmd.Parameters[0].Value = order.currentStatus.ToString();
            int id = (int)cmd.ExecuteScalar();

            cmd = new NpgsqlCommand("INSERT INTO order_contain_order_item (id, item_name, flavor, topping, syrup, container, size, whipped_cream, cherry, quantity) VALUES (@id, @item_name, @flavor, @topping, @syrup, @container, @size, @whipped_cream, @cherry, @quantity);", connection);
            cmd.Parameters.Add("id", NpgsqlTypes.NpgsqlDbType.Integer);
            cmd.Parameters.Add("item_name", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Parameters.Add("flavor", NpgsqlTypes.NpgsqlDbType.Unknown);
            cmd.Parameters.Add("topping", NpgsqlTypes.NpgsqlDbType.Unknown);
            cmd.Parameters.Add("syrup", NpgsqlTypes.NpgsqlDbType.Unknown);
            cmd.Parameters.Add("container", NpgsqlTypes.NpgsqlDbType.Unknown);
            cmd.Parameters.Add("size", NpgsqlTypes.NpgsqlDbType.Unknown);
            cmd.Parameters.Add("whipped_cream", NpgsqlTypes.NpgsqlDbType.Boolean);
            cmd.Parameters.Add("cherry", NpgsqlTypes.NpgsqlDbType.Boolean);
            cmd.Parameters.Add("quantity", NpgsqlTypes.NpgsqlDbType.Integer);

            cmd.Prepare();

            foreach (OrderItem orderItem in order.shoppingCart)
            {
                cmd.Parameters[0].Value = id;
                cmd.Parameters[1].Value = orderItem.item.Name;
                cmd.Parameters[5].Value = orderItem.item.Container;
                cmd.Parameters[9].Value = orderItem.quantity;
                MenuItem item = orderItem.item;

                cmd.Parameters[2].Value = DBNull.Value; //Flavor
                cmd.Parameters[3].Value = DBNull.Value; //Topping
                cmd.Parameters[4].Value = DBNull.Value; //Syrup
                cmd.Parameters[6].Value = DBNull.Value; //Size
                cmd.Parameters[7].Value = DBNull.Value; //Whipped cream
                cmd.Parameters[8].Value = DBNull.Value; //Cherry
                if (item is IceCreamScoop)
                {
                    IceCreamScoop icsItem = (IceCreamScoop)item;
                    cmd.Parameters[2].Value = icsItem.Flavour;
                    cmd.Parameters[6].Value = icsItem.size;

                    if (item is Milkshake)
                    {
                        Milkshake msItem = (Milkshake)item;
                        cmd.Parameters[4].Value = msItem.Syrup;
                        cmd.Parameters[7].Value = msItem.whipped_cream; //Whipped cream
                        cmd.Parameters[8].Value = msItem.cherry; //Cherry
                    }
                    else if (item is Sundae)
                    {
                        Sundae sunItem = (Sundae)item;
                        cmd.Parameters[3].Value = sunItem.Topping; //Topping
                        cmd.Parameters[7].Value = sunItem.whipped_cream; //Whipped cream
                        cmd.Parameters[8].Value = sunItem.cherry; //Cherry
                    }
                }
                
                cmd.ExecuteNonQuery();
            }

            cmd = new NpgsqlCommand("INSERT INTO customer_orders (customer_email, order_id) VALUES (@customer_email, @order_id);", connection);
            cmd.Parameters.Add("customer_email", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Parameters.Add("order_id", NpgsqlTypes.NpgsqlDbType.Integer);
            cmd.Prepare();
            cmd.Parameters[0].Value = user.Email;
            cmd.Parameters[1].Value = id;

            int rows_changed = cmd.ExecuteNonQuery();
            return (rows_changed != 0);
        }

        public static string[] GetOptions(string optionTable)
        {
            string queryString = "SELECT name FROM " + optionTable;
            NpgsqlCommand cmd = new NpgsqlCommand(queryString, connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            List<string> options = new List<string>();
            while (reader.Read())
            {
                options.Add(reader.GetString(0));
            }
            reader.Close();
            return options.ToArray();
        }
    }
}
