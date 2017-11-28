﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Menu
{
    /**
    public enum Flavour 
    {
        CHOCOLATE,
        VANILLA,
        STRAWBERRY,
        COOKIE_DOUGH
    }
*/

    public enum Size
    {
        SMALL = 1,
        MEDIUM = 2,
        LARGE = 3
    }

    class IceCreamScoop : MenuItem
    {
        string Flavour { get; set; }
        Size size { get; set; }

        public IceCreamScoop( string name, string flavour, string container, Size size, double cost )
            : base( "Ice Cream", container, ( (int)size * cost ) )
        {
            this.Flavour = flavour;
            this.size = size;
        }
            
    }
}