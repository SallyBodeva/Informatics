using System;

namespace P07._Moving_Part_2
{
    public class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double premis = width * height * length;
            double boxes = 0;
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd=="Done")
                {
                    Console.WriteLine($"{premis-boxes} Cubic meters left.");
                    break;
                }
                boxes+=double.Parse(cmd);
                if (premis < boxes)
                {
                    Console.WriteLine($"No more free space! You need {boxes-premis} Cubic meters more.");
                    break;
                }

            }
        }
    }
}
