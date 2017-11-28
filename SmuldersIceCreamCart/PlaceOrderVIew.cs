using SmuldersIceCreamCart.Users;
using SmuldersIceCreamCart.Orders;
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
    public partial class PlaceOrderView : Form
    {
        User Viewer { get; set; }

        Order order { get; set; }

        public PlaceOrderView(User user)
        {
            this.Viewer = user;
            this.order = new Order();

            InitializeComponent();

            usernameLabel.Text = Viewer.Email;
            PopulateMenu();
        }

        private void PopulateMenu()
        {
            //TODO get the actual menu items list from server.
            MenuItemsListbox.Items.AddRange(new string[] { "Ice Cream Scoop", "Sundae", "Milkshake", "Sides" });
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //logout was clicked. More needs to be done to properly handle this.
            this.DialogResult = DialogResult.Abort;
            Close();
        }

        private void manageAccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //More needs to be done to properly handle this.
            ManageAccount acctmgmt = new ManageAccount(Viewer);

            DialogResult result = acctmgmt.ShowDialog();

            if (result == DialogResult.Abort)
            {
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            //TODO Verify the order in some fashion and submit. If success, do below. If not, set result to No.
            this.DialogResult = DialogResult.Yes;
            Close();
        }

        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            //Just discard the order and move on with life.
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
