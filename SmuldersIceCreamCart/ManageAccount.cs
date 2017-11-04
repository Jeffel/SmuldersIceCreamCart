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
    public partial class ManageAccount : Form
    {
        User Viewer { get; set; }

        public ManageAccount(User viewer)
        {
            this.Viewer = viewer;

            InitializeComponent();
        }

        private void PswdChangeButton_Click(object sender, EventArgs e)
        {
            ChangePassword pswdChange = new ChangePassword(Viewer);

            DialogResult result = pswdChange.ShowDialog();
        }

        private void DeleteActButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete your account?\nThis action can not be undone.", "Delete Account", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                DialogResult = DialogResult.Abort;
                Close();
            }            
        }
    }
}
