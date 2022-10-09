using System;

public class Program
{
    static void Main()
    {
        int people = int.Parse(Console.ReadLine());
        int budget = int.Parse(Console.ReadLine());

        double sum = 0;

        double countEB = Math.Ceiling(people / 3.00);
        int countEggs = people * 2;
        sum += (countEB * 4) + (countEggs * 0.45);
        if (budget>=sum)
        {
            Console.WriteLine($"Lyubo bought {countEB} Easter bread and {countEggs} eggs.");
            Console.WriteLine($"He has {(budget-sum):f2} lv. left.");
        }
        else
        {
            Console.WriteLine($"Lyubo doesn't have enough money.");
            Console.WriteLine($"He needs {(sum-budget):f2} lv. more.");
        }
    }
}

