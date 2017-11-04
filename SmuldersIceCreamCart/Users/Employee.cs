using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Users
{
    public class Employee : User
    {
        int HoursWorked { get; set; }
        double HourlyWage { get; set; } //From these two, we can get the total pay they've earned.

        Schedule Schedule { get; set; }

        public Employee(string email, string firstName, string lastName, string phoneNum, float hoursWorked, float hourlyWage) 
            : base(email, firstName, lastName, phoneNum)
        {
            IsAdmin = true;
        }
    }
}
