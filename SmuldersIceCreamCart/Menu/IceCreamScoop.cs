using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Menu
{
    /**
    public enum Flavour 
    {
        CHOCOLATE,
        VANILLA,
        STRAWBERRY,
        COOKIE_DOUGH
    }
*/

    public enum Size
    {
        SMALL = 1,
        MEDIUM = 2,
        LARGE = 3
    }

    class IceCreamScoop : MenuItem
    {
        public string Flavour { get; set; }
        public Size size { get; set; }

        public IceCreamScoop( string name, string flavour, string container, Size size, double cost )
            : base( "Ice Cream", container, ( (int)size * cost ) )
        {
            this.Flavour = flavour;
            this.size = size;
        }

        public override string ToString()
        {
            string label = "Ice Cream   Flavour: " + this.Flavour + " Size: " + this.size +
                " Container: " + this.Container;
            label += " " + this.Cost;
            return label;
        }

        public override string[] BuildMenuItem()
        {
            string[] result = { "ice cream", this.Flavour, this.Container, this.size.ToString(), this.Cost.ToString() };
            return result;
        }

    }
}
