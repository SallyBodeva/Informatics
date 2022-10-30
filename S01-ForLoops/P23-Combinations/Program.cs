using System;
using System.Runtime.Serialization;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 0; i <= n; i++)
        {
            for (int l = 0; l <= n; l++)
            {
                for (int o = 0; o <= n; o++)
                {
                    if ((i+l+o)==n)
                    {
                        counter++;
                    }
                }
            }
        }
        Console.WriteLine(counter);
    }
}

