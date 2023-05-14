﻿using System;
using System.Runtime.InteropServices;

namespace Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double moneyCount = 0;

            while (command != "Start")
            {
                double coins = double.Parse(command);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 ||
                    coins == 1 || coins == 2)
                {
                    moneyCount += coins;
                } else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                /*
                 * • "Nuts" with a price of 2.0
                   • "Water" with a price of 0.7
                    • "Crisps" with a price of 1.5
                    • "Soda" with a price of 0.8
                    • "Coke" with a price of 1.0
                 */

                string product = command;
                bool invalid = false;
                double price = 0;

                switch (product)
                {
                    case "Nuts":
                        price = 2;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        invalid = true;
                        break;
                }

                string newName = product;
                newName[0] = Char.ToLower(newName[0]).ToString();
                
                if (!invalid)
                {
                    if (moneyCount >= price)
                    {
                        Console.WriteLine($"Purchased {newName}");
                        moneyCount -= price;
                    } else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Change: {moneyCount:f2}");
        }
    }
}