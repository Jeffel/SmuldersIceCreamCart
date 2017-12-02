using System;
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
            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO orders (status) VALUES (@status) RETURNING id;", connection);
            cmd.Parameters.Add("status", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Parameters.Add("time_placed", NpgsqlTypes.NpgsqlDbType.Timestamp);
            cmd.Prepare();
            cmd.Parameters[0].Value = order.currentStatus.ToString();
            cmd.Parameters[1].Value = DateTime.Now;
            int id = (int)cmd.ExecuteScalar();

            //Inserting into order_contain_order_items is BROKEN
            //TODO Fix this!!!

            cmd = new NpgsqlCommand("INSERT INTO order_contain_order_item (id, item_name, flavor, topping, container, size, whipped_cream, cherry, quantity, syrup, side_item) VALUES (@id, @item_name, @flavor, @topping, @container, @size, @whipped_cream, @cherry, @quantity, @syrup, @side_item);", connection);
            cmd.Parameters.Add("id", NpgsqlTypes.NpgsqlDbType.Integer);
            cmd.Parameters.Add("item_name", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Parameters.Add("flavor", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Parameters.Add("topping", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Parameters.Add("container", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Parameters.Add("size", NpgsqlTypes.NpgsqlDbType.Integer);
            cmd.Parameters.Add("whipped_cream", NpgsqlTypes.NpgsqlDbType.Boolean);
            cmd.Parameters.Add("cherry", NpgsqlTypes.NpgsqlDbType.Boolean);
            cmd.Parameters.Add("quantity", NpgsqlTypes.NpgsqlDbType.Integer);
            cmd.Parameters.Add("syrup", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Parameters.Add("side_item", NpgsqlTypes.NpgsqlDbType.Varchar);

            cmd.Prepare();

            foreach ( OrderItem order_item in order.shoppingCart )
            {
                cmd.Parameters[0].Value = id;
                cmd.Parameters[1].Value = order_item.item.Name;
                cmd.Parameters[2].Value = order_item.item.Flavour;
                cmd.Parameters[3].Value = order_item.item.Topping;
                cmd.Parameters[9].Value = order_item.item.Syrup;
                cmd.Parameters[4].Value = order_item.item.Container;
                cmd.Parameters[5].Value = order_item.item.Size;
                cmd.Parameters[6].Value = order_item.item.Whipped_cream;
                cmd.Parameters[7].Value = order_item.item.Cherry;
                cmd.Parameters[8].Value = order_item.quantity;
                if (order_item.item is SideItem)
                {
                    cmd.Parameters[10].Value = ((SideItem)order_item.item).SideName;
                }
                else
                {
                    cmd.Parameters[10].Value = "None";
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

        public static int GetSideItemID( string name )
        {
            string queryString = "SELECT side_item_id FROM side_item WHERE item_name=" + name;
            NpgsqlCommand cmd = new NpgsqlCommand(queryString, connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            int id = reader.GetInt32(0);
            reader.Close();
            return id;
        }

        public static string[] GetOptions(string optionTable)
        {
            string queryString;
            if(optionTable == "side_item")
            {
                queryString = "SELECT item_name FROM " + optionTable;
            }
            else
            {
                queryString = "SELECT name FROM " + optionTable;
            }
            NpgsqlCommand cmd = new NpgsqlCommand(queryString, connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            List<string> options = new List<string>();
            while (reader.Read())
            {
                if(optionTable != "side_item")
                {
                    options.Add(reader.GetString(0));
                }
                else if(reader.GetString(0) != "None")
                {
                    options.Add(reader.GetString(0));
                }
            }
            reader.Close();
            return options.ToArray();
        }

        // queries menu_item table for the cost of a product
        //applies to ice cream items
        public static double GetItemCost( string optionTable )
        {
            string queryString = "SELECT cost FROM menu_item WHERE name='" + optionTable + "';";
            NpgsqlCommand cmd = new NpgsqlCommand(queryString, connection);
            var cost = cmd.ExecuteScalar();
            if (cost is null)
            {
                return 0.00;
            }
            else
            {
                return Convert.ToDouble(cost);
            }
        }

        // queries side_item table for the cost of a specific side item
        public static double GetSideItemCost( string sideItemName )
        {
            string queryString = "SELECT item_cost FROM side_item WHERE item_name='" + sideItemName + "';";
            NpgsqlCommand cmd = new NpgsqlCommand(queryString, connection);
            var cost = cmd.ExecuteScalar();
            if (cost is null)
            {
                return 0.00;
            } else
            {
                return Convert.ToDouble(cost);
            }
        }

        
        //this uses the orderID string selected by the customer from their list of orderIds
        // what is returned can be used to build the receipt
        public static string[] OrderFromOrderHistory(string orderID )
        {
            List<string> orderHistory = new List<string>();
            string queryString = "SELECT * FROM order_contain_order_item WHERE orderID=@orderID;";
            NpgsqlCommand cmd = new NpgsqlCommand(queryString, connection);
            cmd.Parameters.Add("orderID", NpgsqlTypes.NpgsqlDbType.Integer);
            cmd.Prepare();
            cmd.Parameters[0].Value = orderID;

            NpgsqlDataReader reader = cmd.ExecuteReader();
            while( reader.Read())
            {
                orderHistory.Add(reader.GetString(0));
            }
            reader.Close();
            return orderHistory.ToArray();
        }

        //this is used to display a list of orders that a customer has made

        public static string[] OrderHistoryList( string customer_email )
        {
            List<string> orderList = new List<string>();
            //lazy man's way of doing this
            string queryString = "SELECT order_id FROM customer_orders WHERE customer_email=@customer_email ORDER BY order_id DESC";
            NpgsqlCommand cmd = new NpgsqlCommand(queryString, connection);
            cmd.Parameters.AddWithValue("@customer_email", customer_email);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    orderList.Add(reader.GetString(0));
                }
            }
            reader.Close();
            return orderList.ToArray();
        }

        // this is used to print order summary on receipt
        // summary includes: order_id, time placed, time fulfilled, and status
        public static List<string> OrderStatusSummary( string order_id )
        {
            List<string> order_summary = new List<string>();
            string queryString = "SELECT order_id, time_placed, time_fulfilled, status FROM customer_orders WHERE order_id=@order_id;";
            NpgsqlCommand cmd = new NpgsqlCommand(queryString, connection);
            cmd.Parameters.Add("order_id", NpgsqlTypes.NpgsqlDbType.Integer);
            cmd.Prepare();
            cmd.Parameters[0].Value = order_id;
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while( reader.Read() )
            {
                order_summary.Add(reader.GetString(0));
            }
            reader.Close();
            return order_summary;
        }

        // retrieves a customer's first and last name
        public static List<string> GetCustomerName( string customer_email )
        {
            List<string> customer_info = new List<string>();
            string queryString = "SELECT person.first_name, person.last_name FROM person WHERE email='" + customer_email + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(queryString, connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                customer_info.Add(reader.GetString(0));
            }
            reader.Close();
            return customer_info;
        }

        //retrieves a customer's billing address info 
        public static List<string> GetCustomerAddress( string customer_email )
        {
            List<string> customer_address = new List<string>();
            string queryString = "SELECT address.street_num, address.street_name, address.city, address.state, address.zip FROM address INNER JOIN customer WHERE customer_email=" + customer_email;
            NpgsqlCommand cmd = new NpgsqlCommand(queryString, connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                customer_address.Add(reader.GetString(0));
            }
            reader.Close();
            return customer_address;
        }

        // retrieves a customer's phone number
        public string GetCustomerPhoneNumber( string customer_email )
        {
            string phone;
            string queryString = "SELECT person.phone_number FROM person WHERE email=" + customer_email;
            NpgsqlCommand cmd = new NpgsqlCommand(queryString, connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            phone = reader.GetString(0);
            return phone;
        }

    }
}
