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

            LoginType loginType = Connection.GetLoginType(login, password);

            if(loginType == LoginType.EMPLOYEE) {
                Employee employee = Connection.GetEmployeeFromEmail(login);
                //We now want to show the admin/employee form. It doesn't exist yet. 
                //Lets just show the other one that does exist, but not hide the login so we know!

                EmployeeMainView customerView = new EmployeeMainView(employee);
                DialogResult result = customerView.ShowDialog(); //Will answer 'Did the user logout?'           

                if (result == DialogResult.Yes)
                {
                    loginBox.Text = "";
                    passwordBox.Text = "";
                }
            }

            //Test Customer account.
            else if (loginType == LoginType.CUSTOMER)
            {
                //Test User
                Customer customer = Connection.GetCustomerFromEmail(login);
                CustomerMainView customerView = new CustomerMainView(customer);
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
                MessageBox.Show("Username or Password is incorrect.", "Incorrect Login Info");
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            CreateAccountView createacctView = new CreateAccountView();
            //Need to add more to this view to return information about what went wrong for the user.
            //It will probably handle the showing of the reason why within itself, but I'm doing it here for now.

            DialogResult result = createacctView.ShowDialog(); //Will answer 'Was account created?'

            if(result == DialogResult.Yes)
            {
                loginBox.Text = createacctView.Username;
            }
        }
    }
}
