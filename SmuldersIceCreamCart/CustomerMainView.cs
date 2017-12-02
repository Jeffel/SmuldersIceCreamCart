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
        User Viewer { get; set; }

        public CustomerMainView(User user)
        {
            //Setup from Input Stuff.
            Viewer = user;
            //TODO like the stuff below, fill out the rest of the user info in more text boxes.
            //Later, enable users to edit this info permanently.

            //Get stuff from SQL to store somewhere to get ready.
            //TODO Get order history. Fill the HistoryListbox with the items.

            //Make the components ready to go.
            InitializeComponent();

            HistoryFromDatepick.Value = DateTime.Today.AddDays(-1);
            HistoryToDatepick.Value = DateTime.Now;

            //Setup the form items now that they're ready and we have the data.
            usernameLabel.Text = Viewer.Email;
            NameTextbox.Text = Viewer.FirstName + " " + Viewer.LastName;
            List<string> history = Connection.OrderHistoryList(Viewer.Email);
            foreach (string id in history)
            {
                List<String> order = Connection.OrderFromOrderHistory(id);
                Console.WriteLine(order);//We'll have to build the object, once I know what the output actually is...
            }
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

        private void UpdateInfoButton_Click(object sender, EventArgs e)
        {
            /*This will eventually enable all the textboxes above the button for editing.
            It will then switch to a 'save' button which will trigger validation and handle the state switch back
            based on success or not of the DB info update.
            */
            if(UpdateInfoButton.Text == "Update Info")
            {
                UpdateInfoButton.Text = "Save";
                NameTextbox.Enabled = true;
                //TODO Add more fields to display user info and allow updating.
            }
            else if(UpdateInfoButton.Text == "Save")
            {
                //Do verification and update query here. If success, lock in and switch back to no update mode.
                UpdateInfoButton.Text = "Update Info";
                NameTextbox.Enabled = false;
            }
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            PlaceOrderView orderView = new PlaceOrderView(Viewer);
            //We will want a property within this view to get the actual order class item.
            Hide();
            DialogResult result = orderView.ShowDialog(); //Will answer 'Did the user logout?'           

            if (result == DialogResult.Yes)
            {
                //TODO Order was successfully place.
            }
            else if(result == DialogResult.Abort)
            {
                //TODO Order was stopped mid-place. 'Saved' as in progress.
            }
            else if(result == DialogResult.Cancel)
            {
                //TODO Order was cancelled by user before being placed.
            }
            else if(result == DialogResult.No)
            {
                //TODO Order was not successfully placed. Error.
            }
            HistoryToDatepick.Value = DateTime.Now; //Refresh the SQL listing of history as it may have changed.
            Show();
        }

        private void HistoryListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(HistoryListbox.SelectedItem.ToString()))
            {
                ViewHistoryItemButton.Enabled = false;
            } else
            {
                ViewHistoryItemButton.Enabled = true;
            }
        }

        private void ViewHistoryItemButton_Click(object sender, EventArgs e)
        {
            //Open up a history view of the item in question, this view might enable such things as:
            //Re-ordering the given view. Cancelling an in-progress order.
            //For now the button does nothing but say not implemented.

            MessageBox.Show("Detailed history view is not yet implemented.", "History Item");
        }

        private void HistoryRangeChange(object sender, EventArgs e)
        {
            //TODO refresh the list of orders in the given history range.
        }
    }
}
