using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Menu
{
    class Sundae : IceCreamScoop
    {
        public string Topping { get; set; }
        public bool cherry { get; set; }
        public bool whipped_cream { get; set; }
        public string Flavor { get; set; }

        public Sundae( string Flavour, string Topping, bool cherry, bool whipped_cream, double cost ) 
            : base( "Sundae", Flavour, "dish", 1, cost )
        {
            this.Flavor = Flavor;
            this.Topping = Topping;
            this.cherry = cherry;
            this.whipped_cream = whipped_cream;
        }

        public override string ToString()
        {
            string label = Flavor + " Sundae with " + this.Topping;
            if (this.cherry || this.whipped_cream)
            {
                if (this.whipped_cream && this.cherry)
                {
                    label += " and whipped cream with a cherry";
                }
                else if (this.cherry)
                {
                    label += " and whipped cream";
                }
                else
                {
                    label += " and a cherry";
                }
            }
            label += ": $" + this.Cost;
            return label;
        }

        public override string[] BuildMenuItem()
        {
            string[] result = { "sundae", this.Flavour, "dish", this.Topping, "cherry: " + (this.cherry.ToString() ),
                "whip cream: " + ( this.whipped_cream.ToString() ), "medium", this.Cost.ToString() };
            return result;
        }

    }
}
