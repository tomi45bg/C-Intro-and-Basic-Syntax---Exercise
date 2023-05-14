using System;

namespace Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isDivisible = false;
            int divisibleNumber = 0;

            if (number % 2 == 0)
            {
                isDivisible = true;
                divisibleNumber = 2;
            }

            if (number % 3 == 0)
            {
                isDivisible = true;
                divisibleNumber = 3;
            }

            if (number % 7 == 0)
            {
                isDivisible = true;
                divisibleNumber = 7;
            }

            if (number % 2 == 0 && number % 3 == 0 && number % 6 == 0)
            {
                isDivisible = true;
                divisibleNumber = 6;
            }

            if (number % 2 == 0 && number % 10 == 0)
            {
                isDivisible = true;
                divisibleNumber = 10;
            }

            if (isDivisible)
            {
                Console.WriteLine($"The number is divisible by {divisibleNumber}");
            } else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}