namespace Day5Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Basic Core Programs");
            Console.WriteLine("Enter the number of times you want to flip the coin");
            int n = Convert.ToInt32(Console.ReadLine());
            HeadAndTail.HeadandTailPercentage(n);
            Console.ReadLine();
        }
    }
}