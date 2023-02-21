using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    internal class LeapYear
    {
        public static void LeapYearCheck()
        {
            Console.WriteLine("Enter the Year to check leap year or not");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year > 1000 && year < 10000)
            {
                if ((year % 400) == 0)
                    Console.WriteLine("{0} is a leap year", year);
                else if ((year % 100) == 0)
                    Console.WriteLine("{0} is not a leap year", year);
                else if ((year % 4) == 0)
                    Console.WriteLine("{0} is a leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is a leap year", year);
            }
        }
    }
}
