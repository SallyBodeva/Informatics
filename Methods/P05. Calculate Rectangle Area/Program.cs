using System;


public class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        RectangleArea(a, b);
    }
    public static void RectangleArea(double a, double b)
    {
        Console.WriteLine(a*b);
    }
}

