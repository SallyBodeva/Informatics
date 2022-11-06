using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        string num = Console.ReadLine();
        Sum(num);
    }
    public static void Sum(string n)
    {
        int sumEven = 0;
        int sumOdd = 0;
        foreach (var item in n)
        {
            if (item=='-')
            {

            }
            else
            {
                int digit = item - '0';
                if (digit % 2 == 0)
                {
                    sumEven += digit;
                }
                else
                {
                    sumOdd += digit;
                }
            }
        }
        Console.WriteLine(sumOdd*sumEven);
    }
}
