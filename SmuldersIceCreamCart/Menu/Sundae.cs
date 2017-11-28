using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Menu
{
    class Sundae : IceCreamScoop
    {
        public enum Toppings
        {
            HOTFUDGE,
            BUTTERSCOTCH,
            CARAMEL,
            WHIPPEDCREAM,
            CHERRY,
            PEANUTS
        }

        List<Toppings> toppings { get; }
        Boolean cherry { get; set; }
        Boolean whipped_cream { get; set; }

        public Sundae( Flavour flavour, Toppings topping, Boolean cherry, Boolean whipped_cream, double cost ) 
            : base( "Sundae", flavour, Container.DISH, Size.MEDIUM, cost )
        {
            toppings.Add(topping);

            if( cherry == true )
            {
                toppings.Add(Toppings.CHERRY);
            }

            if( whipped_cream == true )
            {
                toppings.Add(Toppings.WHIPPEDCREAM);
            }
        }

        //this may not be necessary
        public void AddTopping( Toppings topping )
        {
            toppings.Add(topping);
        }

        //this may not be necessary
        public void RemoveTopping( Toppings topping )
        {
            toppings.Remove(topping);
        }
    }
}
