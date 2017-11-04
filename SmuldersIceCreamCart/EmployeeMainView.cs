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
    public partial class EmployeeMainView : Form
    {
        User Viewer { get; set; } //Until we have a user class to store their info, this will suffice.
     
        public EmployeeMainView(User user)
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

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            Close();
        }

        private void CreateAccountsButton_Click(object sender, EventArgs e)
        {
            bool create = true;
            while (create)
            {
                CreateAccountView createacctView = new CreateAccountView(true);
                //Need to add more to this view to return information about what went wrong for the user.
                //It will probably handle the showing of the reason why within itself, but I'm doing it here for now.

                DialogResult result = createacctView.ShowDialog(); //Will answer 'Was account created?'
                DialogResult additional = DialogResult.No;

                if (result == DialogResult.Yes)
                {
                    additional = MessageBox.Show("Account would have been created if it was implemented.\nCreate another?", "Account Created", MessageBoxButtons.YesNo);
                }
                else
                {
                    additional = MessageBox.Show("Invalid X item in your new account.\nCreate another?", "Not Implemented", MessageBoxButtons.YesNo);
                }

                if(additional != DialogResult.Yes)
                {
                    create = false;
                }
            }           
        }

        private void manageAccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageAccount acctmgmt = new ManageAccount(Viewer);

            DialogResult result = acctmgmt.ShowDialog();

            if (result == DialogResult.Abort)
            {
                this.DialogResult = DialogResult.Yes;
                Close();
            }
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Schedules");
        }
    }
}
