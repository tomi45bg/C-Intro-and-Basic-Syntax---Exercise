using System;

namespace Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCrashes = 0;
            int mouseCrashes = 0;
            int keyboardCrashes = 0;
            int displayCrashes = 0;

            for (int i = 1; i <= lostCount; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCrashes++;
                }

                if (i % 3 == 0)
                {
                    mouseCrashes++;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardCrashes++;
                    if (keyboardCrashes % 2 == 0)
                    {
                        displayCrashes++;
                    }
                }
            }

            double headset = headsetCrashes * headsetPrice;
            double mouse = mouseCrashes * mousePrice;
            double keyboard = keyboardCrashes * keyboardPrice;
            double display = displayCrashes * displayPrice;

            double priceAll = headset + mouse + keyboard + display;

            Console.WriteLine($"Rage expenses: {priceAll:f2} lv.");
        }
    }
}