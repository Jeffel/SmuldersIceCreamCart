using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Users
{
    public class Customer : User
    {
        Address BillingAddress { get; set; }
        //OrderHistory orderHistory { get; set; } //We don't care about or have such things _AT THE MOMENT_

        public Customer(string firstName, string lastName, string email, string phoneNum, Address billingAddress) 
            : base(email, firstName, lastName, phoneNum)
        {
            BillingAddress = billingAddress;
            IsAdmin = false;
        }
    }
}
