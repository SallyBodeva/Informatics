using System;

public class Program
{
    static void Main()
    {
        int redCounter = 0;
        int orangeCounter = 0;
        int yellowCounter = 0;
        int whiteCounter = 0;
        int blackCounter = 0;
        int otherColorCounter = 0;

        double points = 0;

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string color = Console.ReadLine();
            switch (color)
            {
                case "red":
                    points += 5;
                    redCounter++;
                    break;
                case "orange":
                    points += 10;
                    orangeCounter++;
                    break;
                case "yellow":
                    points += 15;
                    yellowCounter++;
                    break;
                case "white":
                    points += 20;
                    whiteCounter++;
                    break;
                case "black":
                    points /= 2 ;
                    Math.Floor(points);
                    blackCounter++;
                    break;
                default:
                    break;
            }
            if (color!="red" && color!="orange" && color!="yellow" && color!="white" && color!="black")
            {
                otherColorCounter++;
            }
        }

        Console.WriteLine($"Total points: {Math.Floor(points)}");
        Console.WriteLine($"Red balls: {redCounter}");
        Console.WriteLine($"Orange balls: {orangeCounter}");
        Console.WriteLine($"Yellow balls: {yellowCounter}");
        Console.WriteLine($"White balls: {whiteCounter}");
        Console.WriteLine($"Other colors picked: {otherColorCounter}");
        Console.WriteLine($"Divides from black balls: {blackCounter}");

    }
}

