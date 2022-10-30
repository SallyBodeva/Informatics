using System;


public class Program
{
    static void Main()
    {
        double tournaments = double.Parse(Console.ReadLine());
        int points = int.Parse(Console.ReadLine());
        int addedPoints = 0;
        int wins = 0;
        for (int i = 0; i < tournaments; i++)
        {
            string cmd = Console.ReadLine();
            switch (cmd)
            {
                case "W":
                    addedPoints += 2000;
                    wins++;
                    break;
                case "F":
                    addedPoints += 1200;
                    break;
                case "SF":
                    addedPoints += 720;
                    break;
            }
        }
        Console.WriteLine($"Final points: {points+addedPoints}");
        Console.WriteLine($"Average points: {addedPoints/tournaments}");
        Console.WriteLine($"{(wins/tournaments*100):f2}%");
    }
}
//"Final points: {брой точки след изиграните турнири}"
//"Average points: {средно колко точки печели за турнир}"
//"{процент спечелени турнири}%"

