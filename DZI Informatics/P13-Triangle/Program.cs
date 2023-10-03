using System;

namespace P13_Triangle
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string(' ',n-i)+new string('*',i));
            }
        }
    }
}
