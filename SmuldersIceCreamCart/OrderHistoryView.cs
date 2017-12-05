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
    public partial class OrderHistoryView : Form
    {
        //this should populate the order items from the order_id selected by the customer
        public OrderHistoryView()
        {
            InitializeComponent();
        }

        //this returns the customer back to the CustomerMainView page
        private void HomeButton_Click(object sender, EventArgs e)
        {

        }

        //this prints the current fulfillment status of the order
        private void OrderStatusBox_TextChanged(object sender, EventArgs e)
        {

        }

        //this prints the time the order was fulfilled
        private void TimeFulfilledBox_TextChanged(object sender, EventArgs e)
        {

        }

        //this prints the time the order was placed
        private void TimePlacedBox_TextChanged(object sender, EventArgs e)
        {

        }

        //this prints the total number of items in an order
        //there is a method in the Order class that returns this value
        private void TotalItemBox_TextChanged(object sender, EventArgs e)
        {

        }

        //this prints the total cost of an order
        //there is a method in the Order class that returns this value
        private void TotalCostBox_TextChanged(object sender, EventArgs e)
        {

        }


        //this prints the order id the customer had selected to view the order receipt
        private void OrderIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        //the customer clicked MyAccount-- same as PlaceOrder and CustomerMainView
        private void ManageAccountLink_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        //the customer clicked Logout-- same as PlaceOrder and CustomerMainView
        private void LogoutLink_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
