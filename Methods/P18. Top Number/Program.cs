using System;
using System.Diagnostics.CodeAnalysis;

public class Program
{
    static void Main()
    {
        string n = Console.ReadLine();
        TopNums(n);
    }
    public static void TopNums(string n )
    {

        for (int i = 1; i <= int.Parse(n); i++)
        {
            int sum = 0;
            int oddCounter = 0;
            int nums = 0; ;
            foreach (var digit in i.ToString())
            {
                nums = (digit - '0');
                sum += nums;

                if (nums % 2 == 1)
                {
                    oddCounter += 1;
                }
            }
                if (sum%8==0)
                {
                    if (oddCounter>0)
                    {
                        Console.WriteLine(i);
                    }
                }
        }
    }
}

