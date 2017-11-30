using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Menu
{
    class Milkshake : IceCreamScoop
    {
        /**
        public enum Syrups
        {
            CHOCOLATE,
            MALT,
            STRAWBERRY,
            VANILLA
        }
    */

        public string Syrup { get; set; }
        public bool cherry { get; set; }
        public bool whipped_cream { get; set; }

        public Milkshake( string syrup, bool cherry, bool whipped_cream, double cost )
            : base( "Milkshake", "vanilla", "cup", Size.SMALL, cost )
        {
            this.Syrup = syrup;
            this.cherry = cherry;
            this.whipped_cream = whipped_cream;
        }

        public override string ToString()
        {
            string label = "Milkshake   Syrup: " + Syrup;
            label += this.cherry && this.whipped_cream ? " whip cream and a cherry"
                : this.cherry ? " and a cherry" : " and whip cream";
            label += " " + this.Cost;
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
