using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandroMancusoTraining_Project3
{
    public static class DateTimeExtensions
    {
        public static bool IsLeapYear(this DateTime date)
        {
            return date.Year % 400 == 0;
        }
    }
}
