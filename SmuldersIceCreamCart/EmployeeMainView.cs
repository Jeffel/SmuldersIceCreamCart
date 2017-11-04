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
    }
}
