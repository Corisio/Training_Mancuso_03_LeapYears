using System;

namespace SandroMancusoTraining_Project3
{
    public static class Extensions
    {
        public static bool IsLeapYear(this DateTime date)
        {
            // Alternate construction for the first two ifs
            // if (date.Year.IsDivisibleBy(100))
            // {
            //    return date.Year.IsDivisibleBy(400);
            // }

            if (date.Year.IsDivisibleBy(400))
            {
                return true;
            }

            if (date.Year.IsDivisibleBy(100))
            {
                return false;
            }

            return date.Year.IsDivisibleBy(4);
        }

        private static bool IsDivisibleBy(this int dividend, int divisor)
        {
            return dividend % divisor == 0;
        }
    }
}
