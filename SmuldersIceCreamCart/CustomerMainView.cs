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

            //Get stuff from SQL to store somewhere to get ready.
            //TODO           

            //Make the components ready to go.
            InitializeComponent();

            //Setup the form items now that they're ready and we have the data.
            usernameLabel.Text = Viewer.Email;
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
            PlaceOrderVIew orderView = new PlaceOrderVIew(Viewer);
            //We will want a property within this view to get the actual order class item.
            Hide();
            DialogResult result = orderView.ShowDialog(); //Will answer 'Did the user logout?'           

            if (result == DialogResult.Yes)
            {
                //Order was successfully place.
            }
            else if(result == DialogResult.Abort)
            {
                //Order was stopped mid-place. 'Saved' as in progress.
            }
            else if(result == DialogResult.Cancel)
            {
                //Order was cancelled by user before being placed.
            }
            else if(result == DialogResult.No)
            {
                //Order was not successfully placed. Error.
            }
            Show();
        }
    }
}
