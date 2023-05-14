using System;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";

            for(int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            int countError = 0;
            string command = Console.ReadLine();
            bool correct = true;

            while(command != password)
            {
                countError++;
                if (countError == 4) 
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                correct = false;

                Console.WriteLine("Incorrect password. Try again.");

                command = Console.ReadLine();   

                if (command == password) {
                    correct = true;
                }
            }

            if (correct)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}