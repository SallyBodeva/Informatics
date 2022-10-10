using System;

public class Program
{
    static void Main()
    {
        int redCounter = 0;
        int orangeCounter = 0;
        int blueCounter = 0;
        int greenCounter = 0;
        int max = 0;

        int maxEggs=0;
        string maxColor=null;

        int paintedEggs = int.Parse(Console.ReadLine());
        for (int i = 0; i < paintedEggs; i++)
        {
            string color = Console.ReadLine();
            switch (color)
            {
                case "red":
                    redCounter++;
                    break;
                case "orange":
                    orangeCounter++;
                    break;
                case "blue":
                    blueCounter++;
                    break;
                case "green":
                    greenCounter++;
                    break;
            }
             maxEggs = Math.Max(Math.Max(redCounter, orangeCounter),Math.Max(blueCounter,greenCounter));
            if (redCounter > max)
            {
                max = redCounter;
                maxColor = "red";
            }
            else if (orangeCounter > max)
            {
                max = orangeCounter;
                maxColor = "orange";
            }
            else if (greenCounter > max)
            {
                max = greenCounter;
                maxColor = "green";
            }
            else if (blueCounter > max)
            {
                max = blueCounter;
                maxColor = "blue";
            }
             
        }
        Console.WriteLine($"Red eggs: {redCounter}");
        Console.WriteLine($"Orange eggs: {orangeCounter}");
        Console.WriteLine($"Blue eggs: {blueCounter}");
        Console.WriteLine($"Green eggs: {greenCounter}");
        Console.WriteLine($"Max eggs: {maxEggs} -> {maxColor}");

    }
}
