using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    internal class HarmonicNumber
    {
        public static void HarmonicValue()
        {
            int i;
            double Harmonic = 0.0;
            Console.WriteLine("Enter the number of terms");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n != 0)
            {
                for (i = 1; i <= n; i++)
                {
                    Console.WriteLine("1/{0} + ", i);
                    Harmonic += 1 / (float)i;
                    Console.WriteLine("sum of series upto {0} terms : {1} ", n, Harmonic);
                }
            }
            else
            {
                Console.WriteLine("Enter the number greater than Zero");
            }

        }
    }
}
