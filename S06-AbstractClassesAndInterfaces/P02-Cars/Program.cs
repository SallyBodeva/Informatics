using System;


public class Program
{
    static void Main()
    {
        ICar r = new Renault("Capture", "Red");
        IElectricCar t = new Tesla("Y", "Grey", 2);
        Console.WriteLine(r);
        Console.WriteLine(t);
    }
}

