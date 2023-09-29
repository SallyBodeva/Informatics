using System;

namespace P02_PrimeNums
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int number = 2;
            while (count<n)
            {
                if (number==2 || number == 3 || number == 5 || number == 7 )
                {
                    Console.WriteLine(number);
                    count++;
                }
                else if (number%2!=0 && number%3!=0 && number%5!=0 && number%7!=0)
                {
                    Console.WriteLine(number);
                    count++;
                }
                number++;
            }
        }
    }
}
