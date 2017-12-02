using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Menu
{
    class Milkshake : IceCreamScoop
    {

        public string Syrup { get; set; }
        public bool cherry { get; set; }
        public bool whipped_cream { get; set; }
        public string Flavor { get; set; }

        public Milkshake( string syrup, bool cherry, bool whipped_cream, double cost , string flavor)
            : base( "Milkshake", "vanilla", "cup", 1, cost )
        {
            this.Flavor = flavor;
            this.Syrup = syrup;
            this.cherry = cherry;
            this.whipped_cream = whipped_cream;
        }

        public override string ToString()
        {
           
            string label = Flavor + " Milkshake with " + Syrup + " syrup";
            if (this.cherry || this.whipped_cream)
            {
                if (this.whipped_cream && this.cherry)
                {
                    label += " and whipped cream with a cherry";
                }
                else if(this.cherry)
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
            string[] result = { "milkshake", "vanilla", "cup", this.Syrup, "cherry: " + (this.cherry.ToString() ),
                "whip cream: " + ( this.whipped_cream.ToString() ), "large", this.Cost.ToString() };
            return result;
        }

    }
}
