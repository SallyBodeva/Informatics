using System;

public class Program
{
    static void Main()
    {
        int people = int.Parse(Console.ReadLine());
        double singleMenu = double.Parse(Console.ReadLine());
        double budget = double.Parse(Console.ReadLine());
        if (people>=10&& people<=15)
        {
            singleMenu *= 0.85;
        }
        else if (people>15&&people<=20)
        {
            singleMenu *= 0.80;
            
        }
        else if (people>20)
        {
            singleMenu *= 0.75;
            
        }
      
        double sum = singleMenu * people;
        double cake = budget * 0.1;
        double totalSum = sum + cake;
        if (budget>=totalSum)
        {
            Console.WriteLine($"It is party time! {(budget-totalSum):f2} leva left.");
        }
        else
        {
            Console.WriteLine($"No party! {(totalSum-budget):f2} leva needed.");
        }
    }
}

