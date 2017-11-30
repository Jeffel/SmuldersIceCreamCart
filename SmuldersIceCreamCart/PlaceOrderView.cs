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

        /**
         *  Goes to the Connection class and does a query on all of the tables related to menu items
         *  For each type of item, there is an array of strings ( e.g all the current ice cream flavor names )
         *  This will build our menu.
         */
        private void PopulateMenu()
        {
            //TODO get the actual menu items list from server.
            //@Jeffel these seem to build the menu from their given tables. That's complete, right?
            MenuItemsListbox.Items.AddRange(new string[] { "Ice Cream Scoop", "Sundae", "Milkshake", "Sides" });
            FlavorCBox.Items.AddRange(Connection.GetOptions("flavor"));
            SyrupCBox.Items.AddRange(Connection.GetOptions("syrup"));
            ToppingCBox.Items.AddRange(Connection.GetOptions("topping"));
            SizeCBox.Items.AddRange(Connection.GetOptions("size"));
            ContainerCBox.Items.AddRange(Connection.GetOptions("container"));
        }

        /**
         * The customer logs out by clicking log out button
         * 
        */
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //logout was clicked. More needs to be done to properly handle this.
            //@jeffel Exception handling???
            this.DialogResult = DialogResult.Abort;
            Close();
        }

        /**
         *  This looks like it has to do with managing account info. 
         *  @jen is not going to deal with this right now
        */
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

        /**
         *  Customer clicks the order button to complete an order.
         *  If successful ( and why shouldn't it be ), we print out
         *  a nice thank you message with a confirmationId. 
        */
        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            //TODO Verify the order in some fashion and submit. If success, do below. If not, set result to No.
            //@jeffel the TODO looks done 
            // will go back through the PlaceOrder function
            bool successful = Connection.PlaceOrder(Viewer, order);
            if (successful)
            {
                this.DialogResult = DialogResult.Yes;
                //should we add a message that gives the confirmation???
                //
            } else
            {
                this.DialogResult = DialogResult.No;
            }
            Close();
        }

        //cancel the order completely
        //is there anything that we need to dispose of??
        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            //Just discard the order and move on with life.
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        // this determines which items will display on the order dialog box based on the
        // menu item type
        private void MenuItemsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (MenuItemsListbox.SelectedItem.ToString())
            {
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
                string type = MenuItemsListbox.SelectedItem.ToString();
                order.shoppingCart[CartListbox.SelectedIndex].item = BuildItem(type);
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
            //result = new IceCreamScoop("Temporary", "Vanilla", "Dish", SmuldersIceCreamCart.Menu.Size.LARGE, 12);
            //Ask the current values of drop downs and whatnot on GUI to build the item appropriately instead of filling in manual.
            //think the above has been handled


            //would need to get the cost from the tables
            switch(type) {
                case "Ice Cream Scoop":
                    result = new IceCreamScoop( "Ice Cream", FlavorCBox.SelectedValue.ToString(), ContainerCBox.SelectedValue.ToString(), 
                        (SmuldersIceCreamCart.Menu.Size)SizeCBox.SelectedValue, 0.00 );
                    break;
                case "Sundae":
                    result = new Sundae( FlavorCBox.SelectedValue.ToString(), ToppingCBox.SelectedValue.ToString(), 
                        WhippedCreamCBox.Checked, CherryCBox.Checked, 0.00 );
                    break;
                case "Milkshake":
                    result = new Milkshake( SyrupCBox.SelectedValue.ToString(), WhippedCreamCBox.Checked, CherryCBox.Checked, 0.00);
                    break;
                case "Sides":
                    result = new SideItem( SideItemsListbox.SelectedValue.ToString(), 0.00 );
                    break;
                default:
                    //should additional error checking be done here???
                    result = null;
                    break;
            }
            
            return result;
        }

        //need to enforce number range on gui side
        private void QuantityUD_ValueChanged(object sender, EventArgs e)
        {
            //TODO validate the value put in. This is supposed to be done in Validate methods instead, so this is temporary.
            int qty = int.Parse(QuantityUD.Value.ToString());
            if( qty >= 0 && qty <= 20 )
            {
                //am I changing the model too??
                OrderItem item = order.shoppingCart[CartListbox.SelectedIndex];
                item.quantity = qty;
                order.EditItem(item);
            }
            else
            {
                // do something
            }
        }

        private void EditItemButton_Click(object sender, EventArgs e)
        {
            AddOrderButton.Text = "Save";
            //TODO setup all the menu items down below to their appropriate selections based on the currently selected item.
            //Still a little uncertain on what I am doing here
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

        //function to enable the add to order button.
        private void ValidateOrderItem(object sender, EventArgs e)
        {
            switch (MenuItemsListbox.SelectedItem.ToString())
            {
                case "Ice Cream Scoop":
                    if( int.Parse(QuantityUD.Value.ToString()) > 0 && FlavorCBox.SelectedValue.ToString() != null &&
                        ContainerCBox.SelectedValue.ToString() != null && SizeCBox.ToString() != null )
                    {
                        AddOrderButton.Enabled = true;
                    }
                    break;
                case "Sundae":
                    if (int.Parse(QuantityUD.Value.ToString()) > 0 && FlavorCBox.SelectedValue.ToString() != null &&
                        ToppingCBox.SelectedValue.ToString() != null)
                    {
                        AddOrderButton.Enabled = true;
                    }     
                    break;
                case "Milkshake":
                    if (int.Parse(QuantityUD.Value.ToString()) > 0 && FlavorCBox.SelectedValue.ToString() != null &&
                        SyrupCBox.SelectedValue.ToString() != null)
                    {
                        AddOrderButton.Enabled = true;
                    }
                    break;
                case "Sides":
                    if (int.Parse(QuantityUD.Value.ToString()) > 0 && SideItemsListbox.SelectedValue.ToString() != null)
                    {
                        AddOrderButton.Enabled = true;
                    }
                    break;
                default:
                    AddOrderButton.Enabled = false;
                    break;
            }

        }
    }
}
