using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_TripleNums
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Triple> numbers = new List<Triple>();
            for (int i = 0; i < n; i++)
            {
                int[] num= Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                Triple triple = new Triple(num[0], num[1], num[2]);
                numbers.Add(triple);
            }
            foreach (var item in numbers.OrderBy(x => x.Num1).ThenBy(x => x.Num2).ThenBy(x => x.Num3))
            {
                Console.WriteLine($"{item.Num1} {item.Num2} {item.Num3}");
            }
        }
    }
}
