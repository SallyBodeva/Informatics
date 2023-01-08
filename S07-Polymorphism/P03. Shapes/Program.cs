using System;


public class Program
{
    static void Main()
    {
        Rectangle r = new Rectangle(4, 5);
        Circle c = new Circle(3);
        Console.WriteLine(r.CalculatePerimeter());
        Console.WriteLine(c.CalculateArea());
    }
}

