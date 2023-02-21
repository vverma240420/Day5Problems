using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    internal class PowerOfTwo
    {
        public static void PowerTwo()
        {
            int power = 0;
            Console.WriteLine("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                power = (int)Math.Pow(2, i);
                Console.WriteLine(power);
            }
            Console.WriteLine("Two power {0} = {1}", n, power);
        }
    }
}
