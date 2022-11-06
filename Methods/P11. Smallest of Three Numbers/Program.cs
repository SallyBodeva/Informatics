using System;
using System.ComponentModel;

public class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        PrintSmallest(a, b, c);
    }
    public static void PrintSmallest(int a,int b,int c)
    {
        if (a<b && a<c)
        {
            Console.WriteLine(a);
        }
        else if (b<a && b<c)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }
}
