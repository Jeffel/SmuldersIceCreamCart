using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Menu
{
    class SideItem : MenuItem
    {
        public SideItem( string name, double cost ) 
            : base(name, Container.PLATE, cost )
        {

        }
    }
}
