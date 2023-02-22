using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    internal class LargestAmongThreeNumbers
    {
        public static void FindingLargeNum()
        {
            Console.WriteLine("Enter the Number1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number3");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("number1 is the Largest one");
                }
                else
                {
                    Console.WriteLine("number3 is the Largest one");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("number2 is the Largest one");
            }
            else
            {
                Console.WriteLine("number3 is the Largest one");
            }
        }

    }
}
