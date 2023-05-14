using System;

namespace Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            0 - 2 – baby
            3 - 13 – child
            14 - 19 – teenager
            20 - 65 – adult
            >= 66 – elder
            */

            int age = int.Parse(Console.ReadLine());
            string sex = "";

            if (age >= 0 && age <= 2)
            {
                sex = "baby";
            } else if (age >= 3 && age <= 13)
            {
                sex = "child";
            } else if (age > 13 && age <= 19)
            {
                sex = "teenager";
            } else if (age >= 20 && age <= 65)
            {
                sex = "adult";
            } else
            {
                sex = "elder";
            }

            Console.WriteLine(sex);
        }
    }
}