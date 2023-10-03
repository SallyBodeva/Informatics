using System;

namespace P11_ToTheMoon
{
    public class Program
    {
        static void Main()
        {
            double speed = double.Parse(Console.ReadLine());
            double fuelPer100 = double.Parse(Console.ReadLine());
            double km = 768800;
            double time = Math.Ceiling(km / speed)+3;
            Console.WriteLine(time);
            double fuel = (km * fuelPer100) / 100;
            Console.WriteLine(fuel);
        }
    }
}
