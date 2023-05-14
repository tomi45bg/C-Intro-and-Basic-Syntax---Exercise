using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double price1 = 1;

            switch (type)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        price = 8.45;
                    } else if (day == "Saturday")
                    {
                        price = 9.80;
                    } else
                    {
                        price = 10.46;
                    }
                    break;
                case "Business":
                    if (day == "Friday")
                    {
                        price = 10.90;
                    }
                    else if (day == "Saturday")
                    {
                        price = 15.60;
                    }
                    else
                    {
                        price = 16;
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        price = 15;
                    }
                    else if (day == "Saturday")
                    {
                        price = 20;
                    }
                    else
                    {
                        price = 22.50;
                    }
                    break;
            }

            price1 = count * price;

            if (type == "Students" && count >= 30)
            {
                price1 -= 0.15 * price1;
            }

            if (type == "Business" && count >= 100)
            {
                price1 -= 10 * price;
            }

            if (type == "Regular" && (count >= 10 && count <= 20))
            {
                price1 -= 0.05 * price;
            }

            Console.WriteLine($"Total price: {price1:f2}");
        }
    }
}