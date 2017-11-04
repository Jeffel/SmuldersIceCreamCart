using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Users
{
    public class Address
    {
        bool isBilling { get; }

        string StreetNum { get; set; }
        string StreetName { get; set; }
        string City { get; set; }
        string State { get; set; }
        string ZipCode { get; set; }

        public Address(bool isBilling, string streetNum, string streetName, string city, string state, string zipCode)
        {
            this.isBilling = isBilling;
            StreetNum = streetNum ?? throw new ArgumentNullException(nameof(streetNum));
            StreetName = streetName ?? throw new ArgumentNullException(nameof(streetName));
            City = city ?? throw new ArgumentNullException(nameof(city));
            State = state ?? throw new ArgumentNullException(nameof(state));
            ZipCode = zipCode ?? throw new ArgumentNullException(nameof(zipCode));
        }
    }
}
