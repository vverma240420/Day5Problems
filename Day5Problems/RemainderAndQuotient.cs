using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    internal class RemainderAndQuotient
    {
        public static void Divmethod()
        {

            Console.WriteLine("Enter the dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());


            int Quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + Quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
