using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Menu
{
    class SideItem : MenuItem
    {
        public string SideName { get; }

        public SideItem( string name, double cost ) 
            : base("Side Item", "plate", cost )
        {
            SideName = name;
        }

        public override string ToString()
        {
            string label = "Side item:  " + this.SideName;
            label += ": $" + this.Cost;
            return label;
        }

        public override string[] BuildMenuItem()
        {
            string[] result = { "side", this.Name, this.Cost.ToString() };
            return result;
        }
    }
}
