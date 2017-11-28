using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Menu
{
  /**  public enum Container
    {
        CUP,
        DISH,
        CONE,
        PLATE
    }
    */

    public abstract class MenuItem
    {
        string Name { get; set; }
        double Cost { get; set; }
        string Container { get; set; }
        
        public MenuItem( string name, string container, double cost)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Container = container;
            this.Cost = cost;
        }
   
    }
}
