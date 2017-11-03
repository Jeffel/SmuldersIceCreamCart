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

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            Username = username; //We use this for convenient filling in on the login box back a window.

            string password = PasswordBox.Text;

            string email = EmailBox.Text;

            string firstName = FirstNameBox.Text;
            string lastName = LastNameBox.Text;

            //We could do phone number and address stuff later? Or I can add it in here too.

            //Use these items to then create the user in the table if it is valid. Send it away!

            bool isValidUser = false;

            if (isValidUser)
            {
                DialogResult = DialogResult.Yes;
            } else
            {
                DialogResult = DialogResult.No;
            }

        }
    }
}
