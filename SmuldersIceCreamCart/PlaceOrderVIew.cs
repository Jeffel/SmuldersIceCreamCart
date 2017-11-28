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
    public partial class PlaceOrderVIew : Form
    {
        User Viewer { get; set; }
        //We will want a property within this view to get the actual order class item.
        //Once we have an order class...
        //Order order { get; set; }

        public PlaceOrderVIew(User user)
        {
            this.Viewer = user;

            InitializeComponent();
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

        }
    }
}
