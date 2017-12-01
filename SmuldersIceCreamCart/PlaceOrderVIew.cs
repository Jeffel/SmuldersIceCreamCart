﻿using SmuldersIceCreamCart.Users;
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
        */
        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
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

        //cancel the order completely
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
            Menu.MenuItem built = this.BuildItem(MenuItemsListbox.SelectedItem.ToString());
            OrderItem item = new OrderItem(built, int.Parse(QuantityUD.Value.ToString()));
            order.AddItem( item );
            this.RefreshShoppingCart(order);
            //ResetOrderWindow(built.Name);
            AddOrderButton.Enabled = false;
        }

        private void ResetOrderWindow(string menu_item)
        {
            switch (menu_item)
            {
                case "Ice Cream Scoop":
                    FlavorCBox.SelectedIndex = -1;
                    ContainerCBox.SelectedIndex = -1;
                    SizeCBox.SelectedIndex = -1;
                    QuantityUD.Value = 0;
                    break;
                case "Sundae":
                    FlavorCBox.SelectedIndex = -1;
                    ToppingCBox.SelectedIndex = -1;
                    break;
                case "Milkshake":
                    FlavorCBox.SelectedIndex = -1;
                    SyrupCBox.SelectedIndex = -1;
                    break;
                case "Sides":
                    SideItemsListbox.SelectedIndex = -1;
                    break;
                default:
                    break;
            }

        }

        //clears the currently displayed shopping cart before displaying the updated shopping cart
        private void RefreshShoppingCart( Order order )
        {
            CartListbox.Items.Clear();
            CartListbox.Items.AddRange( order.shoppingCart.ToArray() );
        }

        //Takes the values selected on a menu page and builds a menu item from that
        //TODO hard coded price for now
        //NEED TO FIX QUERY!!!
        private Menu.MenuItem BuildItem(string type)
        {
            Menu.MenuItem result;

            switch(type) {
                case "Ice Cream Scoop":
                    result = new IceCreamScoop( "Ice Cream", FlavorCBox.SelectedItem.ToString(), ContainerCBox.SelectedItem.ToString(), 
                        int.Parse(SizeCBox.SelectedItem.ToString()), 2.00 );
                    break;
                case "Sundae":
                    result = new Sundae( FlavorCBox.SelectedItem.ToString(), ToppingCBox.SelectedItem.ToString(), 
                        WhippedCreamCBox.Checked, CherryCBox.Checked, 5.00);
                    break;
                case "Milkshake":
                    result = new Milkshake( SyrupCBox.SelectedItem.ToString(), WhippedCreamCBox.Checked, CherryCBox.Checked, 
                        5.00);
                    break;
                case "Sides":
                    result = new SideItem( SideItemsListbox.SelectedIndex.ToString(), 
                        3.00);
                    break;
                default:
                    //should additional error checking be done here???
                    result = null;
                    break;
            }
            
            return result;
        }

        //For the quantity drop down box, enforces a valid range
        private void QuantityUD_ValueChanged(object sender, EventArgs e)
        {
            int qty = int.Parse(QuantityUD.Value.ToString());
            if( qty < 0 ) 
            {
                QuantityUD.Value = 0;
            }
            else if( qty > 1000000 )
            {
                QuantityUD.Value = 1000000;
            }
      
        }

        //this is replacing the EditItemButton_Click
        //it removes an item but I am not changing the name since it is tied to design code
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            OrderItem current = order.shoppingCart[CartListbox.SelectedIndex];
            order.RemoveItem(current);
            this.RefreshShoppingCart(this.order);
        }

        //this handles enabling/disabling the edit and remove buttons from an order dialog box
        private void CartListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CartListbox.SelectedIndex.ToString()))
            {
                //EditItemButton.Enabled = false;
                RemoveItemButton.Enabled = false;
            }
            else
            {
                //EditItemButton.Enabled = true;
                RemoveItemButton.Enabled = true;
            }
        }

        //function to enable the add to order button
        //enforces that all mandatory fields have a value
        private void ValidateOrderItem(object sender, EventArgs e)
        {
        
            switch (MenuItemsListbox.SelectedItem.ToString())
            {
                case "Ice Cream Scoop":
                    if (FlavorCBox.SelectedIndex > -1  &&
                        ContainerCBox.SelectedIndex > -1 &&
                        SizeCBox.SelectedIndex > -1)
                    {
                        AddOrderButton.Enabled = true;
                    }
                    break;
                case "Sundae":
                    
                    if ( FlavorCBox.SelectedIndex > -1 && 
                        ToppingCBox.SelectedIndex > -1 )
                    {
                        AddOrderButton.Enabled = true;
                    }     
                    break;
                case "Milkshake":
                    if ( FlavorCBox.SelectedIndex > -1 && 
                        SyrupCBox.SelectedIndex > -1 )
                    {
                        AddOrderButton.Enabled = true;
                    }
                    break;
                case "Sides":
                    if ( SideItemsListbox.SelectedIndex > -1 )
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
