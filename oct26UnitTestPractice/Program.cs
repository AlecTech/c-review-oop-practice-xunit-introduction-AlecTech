using System;
using Xunit;


namespace oct26UnitTestPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int DivideByTwo(int number)
        {
            return number / 2;
        }

        public static bool PerfectSquare(int number)
        {
            return Math.Sqrt(number) == Math.Ceiling(Math.Sqrt(number));
        }
        public static void ThrowsFormatException()
        {
            int.Parse("Hello");
        }
    }
}
