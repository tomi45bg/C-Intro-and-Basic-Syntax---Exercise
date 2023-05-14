using System;

namespace Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int curr = 1;

            for(int i = 0; i < number; i++)
            {
                for(int j = 0; j < i + 1; j++)
                {
                    Console.Write(curr + " ");
                }
                curr++;
                Console.WriteLine();
            }
        }
    }
}