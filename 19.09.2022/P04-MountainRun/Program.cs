using System;

namespace P04_MountainRun
{
    public class Program
    {
        static void Main(string[] args)
        {
            double RecordSec = double.Parse(Console.ReadLine());
            double metres= double.Parse(Console.ReadLine());
            double metersPerSec = double.Parse(Console.ReadLine());

            double lengthSec = metres * metersPerSec;
            double slowdown = Math.Floor(metres / 50) * 30;
            double time = lengthSec + slowdown;
            if (time<RecordSec)
            {
                Console.WriteLine($"Yes! The new record is {time:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {time-RecordSec:f2} seconds slower.");
            }


        }
    }
}
