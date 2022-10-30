using System;


public class Program
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int sum = 0;
        while (true)
        {
            int nums = int.Parse(Console.ReadLine());
            sum += nums;
            if (sum>=firstNum)
            {
                Console.WriteLine(sum);
                break;
            }
        }
        
    }
}

