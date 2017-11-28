using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Menu
{
    public enum Container
    {
        CUP,
        DISH,
        CONE,
        PLATE
    }

    public abstract class MenuItem
    {
        string Name { get; set; }
        double Cost { get; set; }
        Container container;
        
        public MenuItem( string name, Container container, double cost)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.container = container;
            this.Cost = cost;
        }
   
    }
}
