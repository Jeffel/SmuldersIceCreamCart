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
        Boolean cherry { get; set; }
        Boolean whipped_cream { get; set; }

        public Sundae( string Flavour, string Topping, Boolean cherry, Boolean whipped_cream, double cost ) 
            : base( "Sundae", Flavour, "dish", Size.MEDIUM, cost )
        {
            this.Topping = Topping;
            this.cherry = cherry;
            this.whipped_cream = whipped_cream;
        }

    }
}
