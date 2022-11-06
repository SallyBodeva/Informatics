using System;


public class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        PrintTriangle(count);
    }
    static void PrintTriangle(int n)
    {
        for (int counter = 1; counter <= n; counter++)
        {
            for (int i = 1; i <= counter; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        for (int i = 1; i < n; n--)
        {
            for (int j = 1; j < n; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }

}

