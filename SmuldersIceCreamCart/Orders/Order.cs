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
        //public DateTime orderDate { get; set; }
        private string time_placed { get; set; }
        private string time_complete { get; set; }

        public Order( )
        {
            shoppingCart = new List<OrderItem>();
            totalCost = 0.00;
            currentStatus = Status.HOLD;
        }

        public Order(string status, string timeplaced, string timecomplete)
        {
            currentStatus = (Status) Enum.Parse(typeof(Status), status);
            time_placed = timeplaced;
            time_complete = timecomplete;
            shoppingCart = new List<OrderItem>();
            totalCost = 0.00;
        }

        //what's the total cost of an order?
        public double GetOrderCost()
        {
            return this.totalCost;
        }

        //add a new item to the shopping cart and update totalCost
        //assumes item DNE in shopping cart
        public void AddItem(OrderItem item)
        {
            bool shouldAdd = true;
            foreach (OrderItem orderItem in shoppingCart)
            {
                if (orderItem.item.ToString().Equals(item.item.ToString()))
                {
                    orderItem.quantity += item.quantity;
                    shouldAdd = false;
                    break;
                }
            }
            if (shouldAdd) { 
                this.shoppingCart.Add(item);
            }
            totalCost += item.totalCostForItem();
        }

        //remove an item from the shopping cart and update totalCost
        //after this, the item is GONE
        public void RemoveItem( OrderItem item)
        {
            if (this.shoppingCart.Contains( item ) )
            {
                this.shoppingCart.Remove(item);
                totalCost -= item.totalCostForItem();
            }
            else
            {
                throw new NullReferenceException(); 
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

        public override string ToString()
        {
            string str = "Order:\n Placed:" + time_placed + "\n Complete:" + time_complete + "\n";
            /*foreach (OrderItem item in shoppingCart)
            {
                str += "\t" + item.ToString() + "\n"; 
            } //We don't need this anymore, we can get each item in the history reload now. */
            return str;
        }
    }
}
