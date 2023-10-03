using System;

namespace P14_DigitalSquare
{
    public class Program
    {
        static void Main()
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            int sum = 0;
            while (num > 0)
            {
                    sum += num % 10;
                    num /= 10;
            }
            if (sum>10)
            {
                int newNum = sum;
                sum = 0;
                while (newNum > 0)
                {
                    sum += newNum % 10;
                    newNum /= 10;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
