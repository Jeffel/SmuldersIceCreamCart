using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Menu
{
    class Milkshake : IceCreamScoop
    {
        public enum Syrups
        {
            CHOCOLATE,
            MALT,
            STRAWBERRY,
            VANILLA
        }

        Syrups syrup { get; set; }
        Boolean cherry { get; set; }
        Boolean whipped_cream { get; set; }

        public Milkshake( Syrups syrup, Boolean cherry, Boolean whipped_cream, double cost )
            : base( "Milkshake", Flavour.VANILLA, Container.CUP, Size.LARGE, cost )
        {
            this.syrup = syrup;
            this.cherry = cherry;
            this.whipped_cream = whipped_cream;
        }

        public List<Sundae.Toppings> optionalToppings()
        {
            List<Sundae.Toppings> toppings = new List<Sundae.Toppings>();
            if( this.cherry == true )
            {
                toppings.Add(Sundae.Toppings.CHERRY);
            }

            if( this.whipped_cream == true )
            {
                toppings.Add(Sundae.Toppings.WHIPPEDCREAM);
            }

            return toppings;
        }

    }
}
