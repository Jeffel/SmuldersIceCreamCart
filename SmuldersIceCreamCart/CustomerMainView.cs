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
        string Username { get; set; }

        public CustomerMainView(string username)
        {
            //Setup from Input Stuff.
            Username = username;

            //Get stuff from SQL to store somewhere to get ready.
            //TODO           

            //Make the components ready to go.
            InitializeComponent();

            //Setup the form items now that they're ready and we have the data.
            usernameLabel.Text = Username;
        }
    }
}
