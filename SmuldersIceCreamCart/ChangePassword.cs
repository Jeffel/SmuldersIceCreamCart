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
    public partial class ChangePassword : Form
    {
        User person;
        public ChangePassword(User person)
        {
            this.person = person;

            InitializeComponent();
        }

        private void ConfirmChangeButton_Click(object sender, EventArgs e)
        {
            //Check if the current password is valid.
            string current = OldPassBox.Text;

            bool validCurrent = true;

            if (validCurrent)
            {
                DialogResult = DialogResult.OK;
                MessageBox.Show("Password change would have been successful if it were implemented.");
                Close();
            } else
            {
                MessageBox.Show("Invalid current password. Please try again.");
            }

            //Do the stuff to actually change the password here.
        }

        private void NewPassMatchBox_TextChanged(object sender, EventArgs e)
        {
            if(NewPassMatchBox.Text == NewPassBox.Text)
            {
                PassMatchCheckLabel.Text = "MATCH";
                ConfirmChangeButton.Enabled = true;
            }
            else
            {
                PassMatchCheckLabel.Text = "X";
                ConfirmChangeButton.Enabled = false;
            }
        }
    }
}
