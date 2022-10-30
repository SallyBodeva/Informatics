using System;


public class Program
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        int p1 = 0;
        int p2 = 0;
        int p3 = 0;
        int p4 = 0;
        int p5 = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num < 200)
            {
                p1 += 1;
            }
            else if (num >= 200 && num <= 399)
            {
                p2 += 1;
            }
            else if (num >= 400 && num <= 599)
            {
                p3 += 1;
            }
            else if (num >= 600 && num <= 799)
            {
                p4 += 1;
            }
            else if (num >= 800)
            {
                p5 += 1;
            }
        }
        double p1Percent = p1 / n * 100.00;
        double p2Percent = p2 / n * 100.00;
        double p3Percent = p3 / n * 100.00;
        double p4Percent = p4 / n * 100.00;
        double p5Percent = p5 / n * 100.00;
        Console.WriteLine($"{p1Percent:f2}%");
        Console.WriteLine($"{p2Percent:f2}%");
        Console.WriteLine($"{p3Percent:f2}%");
        Console.WriteLine($"{p4Percent:f2}%");
        Console.WriteLine($"{p5Percent:f2}%");
    }
}

