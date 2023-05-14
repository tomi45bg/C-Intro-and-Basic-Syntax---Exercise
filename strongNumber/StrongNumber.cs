using System;

namespace strongNumber
{
    internal class StrongNumber
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int originalNum = num;
            bool isStrong = false;

            int sum = 0;
            while (num != 0)
            {
                int digit = num % 10;
                int sumFact = 1;

                for (int i = 1; i <= digit; i++)
                {
                    sumFact *= i;
                }

                sum += sumFact; 

                num /= 10;
            }

            if (sum == originalNum)
            {
                isStrong = true;
            }

            if (isStrong)
            {
                Console.WriteLine("yes");
            } else
            {
                Console.WriteLine("no");
            }
        }
    }
}