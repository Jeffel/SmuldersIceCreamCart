using SmuldersIceCreamCart.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmuldersIceCreamCart
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string password = passwordBox.Text;

            //Placeholder login query stuff here. Likely call some form of controller class to populate info and pass it onto the form.

            //Test Admin account.
            if(password == "smulder")
            {
                //Test User
                Employee specialUser = new Employee(0, login, "Smulder", "Smulder", "h0tDr4g0n@netscape.com", "5", 
                    new Address(false, "123", "Sesame Street", "New York", "NY", "10023"));
                //We now want to show the admin/employee form. It doesn't exist yet. 
                //Lets just show the other one that does exist, but not hide the login so we know!

                EmployeeMainView customerView = new EmployeeMainView(specialUser);
                DialogResult result = customerView.ShowDialog(); //Will answer 'Did the user logout?'           

                if (result == DialogResult.Yes)
                {
                    loginBox.Text = "";
                    passwordBox.Text = "";
                }
            }

            //Test Customer account.
            else if (password == "peasant")
            {
                //Test User
                Customer peasant = new Customer(1, login, "Peasant", "Scum", "2poor5icecream@yahoo.com", "(585) 555-1234",
                    new Address(false, "666", "Dirt Road", "Detroit", "MI", "48127"),
                    new Address(true, "1600", "Pennsylvania Avenue", "Washington", "DC", "20500"));
                CustomerMainView customerView = new CustomerMainView(peasant);
                Hide();
                DialogResult result = customerView.ShowDialog(); //Will answer 'Did the user logout?'           

                if(result == DialogResult.Yes)
                {
                    loginBox.Text = "";
                    passwordBox.Text = "";
                }

                Show();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect.", "HINT: Try smulder or peasant as your password.");
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //Stuff to create an account. Likely another form popover window dialog with all the form items the DB needs.
            MessageBox.Show("Create account not yet implemented.", "Create Account");
        }
    }
}
