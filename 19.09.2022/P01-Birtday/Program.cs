using System;

namespace P01_Birtday
{
    public class Program
    {
        static void Main()
        {
            int rent = int.Parse(Console.ReadLine());
            

            double cake = 0.2*rent;
            double beverage = cake - (cake * 0.45);
            double animator = rent / 3;
            double budget = rent + cake + beverage + animator;
            Console.WriteLine(budget);
        }
    }
}
