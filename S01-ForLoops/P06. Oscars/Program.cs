using System;


public class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        double academicPoints = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            string judgeName = Console.ReadLine();
            double judgePoints = double.Parse(Console.ReadLine());
            academicPoints += ((judgeName.Length * judgePoints) / 2.0);
        }
        if (academicPoints>=1250.5)
        {
            Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {academicPoints}!");
        }
        else
        {
            Console.WriteLine($"Sorry, {name} you need {(1250.5-academicPoints):f1} more!");
        }
    }
}

