using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Users
{
    public abstract class User
    {
        protected int id { get; }
        public string Username { get; }
        protected bool IsAdmin { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string PhoneNum { get; set; }

        public Address Address { get; set; }

        public User(int id, string username, string firstName, string lastName, string email, string phoneNum, Address address)
        {
            this.id = id;
            Username = username ?? throw new ArgumentNullException(nameof(username));
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            PhoneNum = phoneNum ?? throw new ArgumentNullException(nameof(phoneNum));
            Address = address ?? throw new ArgumentNullException(nameof(address));
        }
    }
}
