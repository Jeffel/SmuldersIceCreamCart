using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Menu
{
    class Sundae : IceCreamScoop
    {

        public Sundae( string Flavour, string Topping, bool cherry, bool whipped_cream, double cost ) 
            : base( "Sundae", Flavour, "dish", 1, cost )
        {
            this.Flavour = Flavour;
            this.Topping = Topping;
            this.Cherry = cherry;
            this.Whipped_cream = whipped_cream;
        }

        public override string ToString()
        {
            string label = Flavour + " Sundae with " + this.Topping;
            if (this.Cherry || this.Whipped_cream)
            {
                if (this.Whipped_cream && this.Cherry)
                {
                    label += " and whipped cream with a cherry";
                }
                else if (this.Cherry)
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
            string[] result = { "sundae", this.Flavour, "dish", this.Topping, "cherry: " + (this.Cherry.ToString() ),
                "whip cream: " + ( this.Whipped_cream.ToString() ), "medium", this.Cost.ToString() };
            return result;
        }

    }
}
