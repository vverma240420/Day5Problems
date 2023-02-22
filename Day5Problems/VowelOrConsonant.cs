using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    internal class VowelOrConsonant
    {
        public static void VowelOrConsonantCheck()
        {
            char ch;
            Console.WriteLine("Enter an Alphabet to Check Vowel Or Not");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("Its a Vowel");
            }
            else
            {
                Console.WriteLine("Its a Consonent");
            }
        }
    }
}
