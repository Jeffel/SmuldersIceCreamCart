using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Menu
{
    class Sundae : IceCreamScoop
    {
        /**
        public enum Toppings
        {
            HOTFUDGE,
            BUTTERSCOTCH,
            CARAMEL,
            WHIPPEDCREAM,
            CHERRY,
            PEANUTS
        }
    */

        public string Topping { get; set; }
        public bool cherry { get; set; }
        public bool whipped_cream { get; set; }

        public Sundae( string Flavour, string Topping, bool cherry, bool whipped_cream, double cost ) 
            : base( "Sundae", Flavour, "dish", Size.SMALL, cost )
        {
            this.Topping = Topping;
            this.cherry = cherry;
            this.whipped_cream = whipped_cream;
        }

        public override string ToString()
        {
            string label = "Sundae   Topping: " + this.Topping;
            label += this.cherry && this.whipped_cream ? " whip cream and a cherry"
                : this.cherry ? " and a cherry" : " and whip cream ";
            label += " " + this.Cost;
            return label;
        }

    }
}
