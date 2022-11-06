using System;


public class Program
{
    static void Main(string[] args)
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        PrintFactoriel(a, b);
    }
    public static void PrintFactoriel(decimal a, decimal b)
    {
        decimal result = 1;
        for (decimal i = 1; i <= a; i++)
        {
            result *= i;
        }
        decimal result2 = 1;
        for (decimal i = 1; i <= b; i++)
        {
            result2*= i;
        }
        Console.WriteLine($"{result/result2:f2}");
    }
}

