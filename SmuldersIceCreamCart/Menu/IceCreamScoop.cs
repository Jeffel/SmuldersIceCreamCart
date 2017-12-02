using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Menu
{


    class IceCreamScoop : MenuItem
    {

        public IceCreamScoop( string name, string flavour, string container, int size, double cost )
            : base( name, container, ( size * cost ) )
        {
            this.Flavour = flavour;
            this.Size = size;
        }

        public override string ToString()
        {
            string label;
            switch (this.Size)
            {
                case 1:
                    label = "Single scoop " + this.Flavour + " Ice Cream in a " + this.Container;
                    break;
                case 2:
                    label = "Double scoop " + this.Flavour + " Ice Cream in a " + this.Container;
                    break;
                case 3:
                    label = "Triple scoop " + this.Flavour + " Ice Cream in a " + this.Container;
                    break;
                default:
                    label = this.Flavour + " Ice Cream in a " + this.Container;
                    break;
            }
            label += ": $" + this.Cost;
            return label;
        }

        public override string[] BuildMenuItem()
        {
            string[] result = { "ice cream", this.Flavour, this.Container, this.Size.ToString(), this.Cost.ToString() };
            return result;
        }

    }
}
