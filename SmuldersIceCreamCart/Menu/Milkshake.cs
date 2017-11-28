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

        string Syrup { get; set; }
        Boolean cherry { get; set; }
        Boolean whipped_cream { get; set; }

        public Milkshake( string syrup, Boolean cherry, Boolean whipped_cream, double cost )
            : base( "Milkshake", "vanilla", "cup", Size.LARGE, cost )
        {
            this.Syrup = syrup;
            this.cherry = cherry;
            this.whipped_cream = whipped_cream;
        }

    }
}
