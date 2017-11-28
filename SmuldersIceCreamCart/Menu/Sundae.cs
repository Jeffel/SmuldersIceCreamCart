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

        string Topping { get; set; }
        bool cherry { get; set; }
        bool whipped_cream { get; set; }

        public Sundae( string Flavour, string Topping, bool cherry, bool whipped_cream, double cost ) 
            : base( "Sundae", Flavour, "dish", Size.MEDIUM, cost )
        {
            this.Topping = Topping;
            this.cherry = cherry;
            this.whipped_cream = whipped_cream;
        }

    }
}
