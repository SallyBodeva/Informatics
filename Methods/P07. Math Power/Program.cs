using System;


public class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        Stepen(a, b);
    }
    public static void Stepen (double a, double b)
    {
        double result = 1;
        for (int i = 0; i < b ; i++)
        {
            result *= a;
        }
        Console.WriteLine(result);
    }
}

