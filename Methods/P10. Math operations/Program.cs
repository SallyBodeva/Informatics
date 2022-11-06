using System;


public class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        char b = char.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        PrintResult(a, b, c);
    }
    public static void PrintResult(double a, char b, double c)
    {
        switch (b)
        {
            case '+':
                Console.WriteLine(a + c);
                break;
            case '-':
                Console.WriteLine(a - c);
                break;
            case '*':
                Console.WriteLine(a * c);
                break;
            case '/':
                Console.WriteLine(a / c);
                break;
        }
    }
}
