using System;


internal class Program
{
    static void Main()
    {
        Box b = null;

        try
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            b = new Box(length, width, heigth);
        }
        catch (Exception ex)
        {
            string message = ex.Message;
            Console.WriteLine(message);
            Environment.Exit(0);
        }
        Console.WriteLine(b.SurfaceArea());
        Console.WriteLine(b.LateralSurfaceArea());
        Console.WriteLine(b.Volume());
    }
}

