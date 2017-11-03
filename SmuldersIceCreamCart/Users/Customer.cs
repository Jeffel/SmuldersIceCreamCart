using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Users
{
    class Customer : User
    {
        Address BillingAddress { get; set; }
        //OrderHistory orderHistory { get; set; } //We don't care about or have such things _AT THE MOMENT_

        public Customer(int id, string username, string firstName, string lastName, string email, string phoneNum, Address deliveryAddress, Address billingAddress) 
            : base(id, username, firstName, lastName, email, phoneNum, deliveryAddress)
        {
            BillingAddress = billingAddress;
            IsAdmin = false;
        }
    }
}
