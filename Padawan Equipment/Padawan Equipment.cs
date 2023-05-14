using System;

namespace Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float moneyJohn = float.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            float priceLightsaber = float.Parse(Console.ReadLine());
            float priceRobe = float.Parse(Console.ReadLine());
            float priceBelt = float.Parse(Console.ReadLine());

            float moneyLightsabers = (float)(priceLightsaber * Math.Ceiling(studentsCount + 0.1 * studentsCount));

            int count6Belts = 0;
            for (int i = 1; i <= studentsCount; i++) {
                if (i % 6 == 0)
                {
                    count6Belts++;
                }
            }

            float money = moneyLightsabers + priceRobe*studentsCount + 
                priceBelt*(studentsCount - count6Belts);

            if (money <= moneyJohn)
            {
                Console.WriteLine($"The money is enough - it would cost {money:f2}lv.");
            } else
            {
                float diff = Math.Abs(money - moneyJohn);
                Console.WriteLine($"John will need {diff:f2}lv more.");
            }
        }
    }
}