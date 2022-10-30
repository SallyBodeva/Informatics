using System;
using System.Diagnostics.CodeAnalysis;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int max = int.MinValue;
        for (int i = 1; i <=n ; i++)
        {
            int nums = int.Parse(Console.ReadLine());
            sum += nums;
            if (nums>max)
            {
                max = nums;
            }
        }
        if (sum-max == max)
        {
            Console.WriteLine($"Yes\r\nSum = {max}\r\n");
        }
        else
        {
            Console.WriteLine($"No\r\nDiff = {Math.Abs(sum-max - max)}\r\n");
        }
    }
}

