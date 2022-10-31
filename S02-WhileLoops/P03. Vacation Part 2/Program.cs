using System;


public class Program
{
    static void Main()
    {
        double neededMoney = double.Parse(Console.ReadLine());
        double savings = double.Parse(Console.ReadLine());
        int days = 0;
        int daysSpending = 0;
        while (true)
        {
            string cmd = Console.ReadLine();
            double money = double.Parse(Console.ReadLine());
            days++;
            if (cmd=="save")
            {
                savings += money;
            }
            else if (cmd=="spend")
            {
                if (money>savings)
                {
                    savings = 0;
                }
                else
                {
                    savings -= money;
                }
                daysSpending++;
            }
            if (daysSpending==5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(days);
                break;
            }
            if (savings>=neededMoney)
            {
                Console.WriteLine($"You saved the money for {days} days.");
                break;
            }
        }
    }
}

