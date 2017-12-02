using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Menu
{
    class Milkshake : IceCreamScoop
    {

        public Milkshake( string syrup, bool cherry, bool whipped_cream, double cost , string flavor)
            : base( "Milkshake", "vanilla", "cup", 1, cost )
        {
            this.Flavour = flavor;
            this.Syrup = syrup;
            this.Cherry = cherry;
            this.Whipped_cream = whipped_cream;
        }

        public override string ToString()
        {
           
            string label = Flavour + " Milkshake with " + Syrup + " syrup";
            if (this.Cherry || this.Whipped_cream)
            {
                if (this.Whipped_cream && this.Cherry)
                {
                    label += " and whipped cream with a cherry";
                }
                else if(this.Cherry)
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
            string[] result = { "milkshake", "vanilla", "cup", this.Syrup, "cherry: " + (this.Cherry.ToString() ),
                "whip cream: " + ( this.Whipped_cream.ToString() ), "large", this.Cost.ToString() };
            return result;
        }
    }
}
