using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Orders
{
    public class Order
    {

        public enum Status
        {
            HOLD,
            UNLFUFILLED,
            FULFILLED
        } //TODO review this for Jen.

        //public Dictionary<Menu.MenuItem, int> shoppingCart { get; }

        public List<OrderItem> shoppingCart;
        double totalCost;
        public Status currentStatus { get; set; }
        public DateTime orderDate { get; set; }

        public Order( )
        {
            shoppingCart = new List<OrderItem>();
            totalCost = 0.00;
            currentStatus = Status.HOLD;
        }

        //what's the total cost of an order?
        public double GetOrderCost()
        {
            return this.totalCost;
        }

        //add a new item to the shopping cart and update totalCost
        //assumes item DNE in shopping cart
        public void AddItem( OrderItem item )
        {
            this.shoppingCart.Add(item);
            totalCost += item.totalCostForItem();
        }

        //remove an item from the shopping cart and update totalCost
        //after this, the item is GONE
        public void RemoveItem( OrderItem item)
        {
            if (this.shoppingCart.Contains( item ) )
            {
                totalCost -= item.totalCostForItem();
            }
            else
            {
                throw new NullReferenceException(); 
            }
        }


        //TODO
        //Jeff will finish filling this out
        public void EditItem( OrderItem item )
        {
            OrderItem itemToEdit;
            if( this.shoppingCart.Contains( item ) )
            {

            }

        }

        //tells you how many unique items are in an order
        //does not account for quantities of items greater than 1
        public int GetOrderSize()
        {
            return this.shoppingCart.Count;
        }

        //sums all of the quantities to give total number of items in a shopping cart
        public int GetTotalNumberofItems()
        {
            int sum = 0;
            foreach( OrderItem item in shoppingCart )
            {
                sum += item.quantity;
            }
            return sum;
        }

        //when a customer changes their mind
        public void ClearOrder()
        {
            this.shoppingCart.Clear();
            this.totalCost = 0.00;
        }


    }
}
