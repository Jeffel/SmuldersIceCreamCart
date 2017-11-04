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
    public partial class CustomerMainView : Form
    {
        User Viewer { get; set; } //Until we have a user class to store their info, this will suffice.

        public CustomerMainView(User user)
        {
            //Setup from Input Stuff.
            Viewer = user;

            //Get stuff from SQL to store somewhere to get ready.
            //TODO           

            //Make the components ready to go.
            InitializeComponent();

            //Setup the form items now that they're ready and we have the data.
            usernameLabel.Text = Viewer.Username;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            Close();
        }

        private void manageAccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageAccount acctmgmt = new ManageAccount(Viewer);

            DialogResult result = acctmgmt.ShowDialog();

            if(result == DialogResult.Abort)
            {
                this.DialogResult = DialogResult.Yes;
                Close();
            }
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Place Order");
        }

        private void OrderHistButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Previous Orders");
        }
    }
}
