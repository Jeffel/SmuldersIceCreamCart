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
    public partial class CreateAccountView : Form
    {
        public string Username { get; set; }

        public CreateAccountView()
        { 
            InitializeComponent();
        }

        public CreateAccountView(bool Admin)
        {
            InitializeComponent();

            if (Admin)
            {
                IsEmployeeCheck.Visible = true;
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            Username = username; //We use this for convenient filling in on the login box back a window.

            string password = PasswordBox.Text;

            string firstName = FirstNameBox.Text;
            string lastName = LastNameBox.Text;

            bool isEmployee = IsEmployeeCheck.Checked;
            //We could do phone number and address stuff later? Or I can add it in here too.

            //Use these items to then create the user in the table if it is valid. Send it away!

            bool isValidUser = Connection.CreateUser(username, password, firstName, lastName, isEmployee);

            if (isValidUser)
            {
                DialogResult = DialogResult.Yes;
            } else
            {
                MessageBox.Show("Username already taken.\nPlease try again.", "Username Taken");
                DialogResult = DialogResult.No;
            }

        }
    }
}
