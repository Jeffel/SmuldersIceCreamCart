using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Menu
{

    public abstract class MenuItem
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public string Container { get; set; }
        public string Flavour { get; set; }
        public string Topping { get; set; }
        public string Syrup { get; set; }
        public bool Cherry { get; set; }
        public bool Whipped_cream { get; set; }
        public double Cost { get; set; }
        
        public MenuItem( string name, string container, double cost)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Container = container;
            this.Cost = cost;

            this.Size = 1;
            this.Flavour = "None";
            this.Topping = "None";
            this.Syrup = "None";
            this.Cherry = false;
            this.Whipped_cream = false;
        }

        // abstract method that requires each type of menu item to 
        // build a list string list of everything related to that item
        public abstract string[] BuildMenuItem();



    }
}
