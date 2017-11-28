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
using SmuldersIceCreamCart.Menu;

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
            FlavorCBox.Items.AddRange(Connection.GetOptions("flavor"));
            SyrupCBox.Items.AddRange(Connection.GetOptions("syrup"));
            ToppingCBox.Items.AddRange(Connection.GetOptions("topping"));
            SizeCBox.Items.AddRange(Connection.GetOptions("size"));
            ContainerCBox.Items.AddRange(Connection.GetOptions("container"));
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
            bool successful = Connection.PlaceOrder(Viewer, order);
            if (successful)
            {
                this.DialogResult = DialogResult.Yes;
            } else
            {
                this.DialogResult = DialogResult.No;
            }
            Close();
        }

        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            //Just discard the order and move on with life.
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void MenuItemsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (MenuItemsListbox.SelectedItem.ToString())
            {
                //TODO fill the respective dropdowns or list(sides) with items from the DB.
                case "Ice Cream Scoop":
                    QuantityLabel.Visible = true;
                    QuantityUD.Visible = true;
                    FlavorLabel.Visible = true;
                    FlavorCBox.Visible = true;
                    ToppingLabel.Visible = false;
                    ToppingCBox.Visible = false;
                    SyrupLabel.Visible = false;
                    SyrupCBox.Visible = false;
                    ContainerLabel.Visible = true;
                    ContainerCBox.Visible = true;
                    SizeLabel.Visible = true;
                    SizeCBox.Visible = true;
                    WhippedCreamCBox.Visible = false;
                    CherryCBox.Visible = false;
                    SideItemsListbox.Visible = false;
                    break;
                case "Sundae":
                    QuantityLabel.Visible = true;
                    QuantityUD.Visible = true;
                    FlavorLabel.Visible = true;
                    FlavorCBox.Visible = true;
                    ToppingLabel.Visible = true;
                    ToppingCBox.Visible = true;
                    SyrupLabel.Visible = false;
                    SyrupCBox.Visible = false;
                    ContainerLabel.Visible = false;
                    ContainerCBox.Visible = false;
                    SizeLabel.Visible = false;
                    SizeCBox.Visible = false;
                    WhippedCreamCBox.Visible = true;
                    CherryCBox.Visible = true;
                    SideItemsListbox.Visible = false;
                    break;
                case "Milkshake":
                    QuantityLabel.Visible = true;
                    QuantityUD.Visible = true;
                    FlavorLabel.Visible = true;
                    FlavorCBox.Visible = true;
                    ToppingLabel.Visible = false;
                    ToppingCBox.Visible = false;
                    SyrupLabel.Visible = true;
                    SyrupCBox.Visible = true;
                    ContainerLabel.Visible = false;
                    ContainerCBox.Visible = false;
                    SizeLabel.Visible = false;
                    SizeCBox.Visible = false;
                    WhippedCreamCBox.Visible = true;
                    CherryCBox.Visible = true;
                    SideItemsListbox.Visible = false;
                    break;
                case "Sides":
                    QuantityLabel.Visible = true;
                    QuantityUD.Visible = true;
                    FlavorLabel.Visible = false;
                    FlavorCBox.Visible = false;
                    ToppingLabel.Visible = false;
                    ToppingCBox.Visible = false;
                    SyrupLabel.Visible = false;
                    SyrupCBox.Visible = false;
                    ContainerLabel.Visible = false;
                    ContainerCBox.Visible = false;
                    SizeLabel.Visible = false;
                    SizeCBox.Visible = false;
                    WhippedCreamCBox.Visible = false;
                    CherryCBox.Visible = false;
                    SideItemsListbox.Visible = true;
                    break;
                default:                
                    break;
            }
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            Menu.MenuItem built;

            if (AddOrderButton.Text == "Save")
            {
                //We are modifying an existing item, use the selected item in the current order.
                order.shoppingCart[CartListbox.SelectedIndex].item = BuildItem("Ice Cream Scoop");
                order.shoppingCart[CartListbox.SelectedIndex].quantity = int.Parse(QuantityUD.Value.ToString());
            }
            else
            {
                switch (MenuItemsListbox.SelectedItem.ToString())
                {
                    default:
                        built = null;
                        break;
                }
            }
        }

        private Menu.MenuItem BuildItem(string type)
        {
            Menu.MenuItem result;

            //TODO Based on if we are saving or not, the type passed in comes from the cart or left menu of item types.
            result = new IceCreamScoop("Temporary", "Vanilla", "Dish", SmuldersIceCreamCart.Menu.Size.LARGE, 12);
            //Ask the current values of drop downs and whatnot on GUI to build the item appropriately instead of filling in manual.
            return result;
        }

        private void QuantityUD_ValueChanged(object sender, EventArgs e)
        {
            //TODO validate the value put in. This is supposed to be done in Validate methods instead, so this is temporary.
        }

        private void EditItemButton_Click(object sender, EventArgs e)
        {
            AddOrderButton.Text = "Save";
            //TODO setup all the menu items down below to their appropriate selections based on the currently selected item.
            Menu.MenuItem current = order.shoppingCart[CartListbox.SelectedIndex].item;
            //Pull from this the necessary information.
        }

        private void CartListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CartListbox.SelectedIndex.ToString()))
            {
                EditItemButton.Enabled = false;
                RemoveItemButton.Enabled = false;
            }
            else
            {
                EditItemButton.Enabled = true;
                RemoveItemButton.Enabled = true;
            }
        }

        private void ValidateOrderItem(object sender, EventArgs e)
        {
            //TODO Write this function to enable the add to order button.
        }
    }
}
