using System;
public class Program
{
    static void Main()
    {
        int points = 0;
        string bestCook = null;
        int betsPoints = 0;

        int easternBread = int.Parse(Console.ReadLine());
        for (int i = 0; i < easternBread; i++)
        {
            string name = Console.ReadLine();
            string input = null;
            while ((input = Console.ReadLine())!="Stop")
            {
                points += int.Parse(input);
            }
            Console.WriteLine($"{name} has {points} points.");
            if (points>betsPoints)
            {
                betsPoints = points;
                bestCook = name;
                Console.WriteLine($"{bestCook} is the new number 1!");
            }
            points = 0;
        }
        Console.WriteLine($"{bestCook} won competition with {betsPoints} points!");
    }
}

