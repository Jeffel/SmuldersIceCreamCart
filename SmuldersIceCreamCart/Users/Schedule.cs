using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuldersIceCreamCart.Users
{
    class Schedule
    {
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        DayOfWeek DayOfWeek { get; set; }

        public Schedule(DateTime startTime, DateTime endTime, DayOfWeek dayOfWeek)
        {
            StartTime = startTime;
            EndTime = endTime;
            DayOfWeek = dayOfWeek;
        }
    }
}
