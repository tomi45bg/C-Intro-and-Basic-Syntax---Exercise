using System;

namespace Orders
{
    internal class Orders
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());
            double price = 0;    

            for (int i = 0; i < ordersCount; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double priceThisMonth = pricePerCapsule * days * capsulesCount;
                price += priceThisMonth;
                Console.WriteLine($"The price for the coffee is: ${priceThisMonth:f2}");
            }

            Console.WriteLine($"Total: ${price:f2}");
        }
    }
}