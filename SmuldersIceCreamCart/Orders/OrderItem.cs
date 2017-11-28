using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Orders
{
    public class OrderItem
    {
        public Menu.MenuItem item { get; set; }
        public int quantity { get; set; }

        public OrderItem( Menu.MenuItem item, int quantity )
        {
            this.item = item;
            this.quantity = quantity;
        }

        //get the total cost for an item when quantity is accounted for
        public double totalCostForItem()
        {
            return this.item.Cost * this.quantity;
        }
    }
}
