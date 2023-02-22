namespace Day5Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Basic Core Programs");
            Console.WriteLine("\n1:HeadAndTail\n2:LeapYear\n3:PowerOfTwo\n4:HarmonicNumber\n5:RemainderAndQuotient\n6:PrimeFactors\n7:SwapTwoNumber\n8:EvenOrOdd\n9:VowelOrConsonant\n11:Exit");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    HeadAndTail.HeadandTailPercentage();
                    break;
                case 2:
                    LeapYear.LeapYearCheck();
                    break;
                case 3:
                    PowerOfTwo.PowerTwo();
                    break;
                case 4:
                    HarmonicNumber.HarmonicValue();
                    break;
                case 5:
                    RemainderAndQuotient.Divmethod();
                    break;
                case 6:
                    PrimeFactors.PrimeFactor();
                    break;
                case 7:
                    SwapTwoNumber.SwapNumbers();
                    break;
                case 8:
                    EvenOrOdd.EvenOrOddCheck();
                    break;
                case 9:
                    VowelOrConsonant.VowelOrConsonantCheck();
                    break;
                default:
                    Console.WriteLine("choose the above options");
                    break;
            }
            Console.ReadLine();
        }
    }
}