using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_SimilarNums
{
    public class Program
    {
        static void Main()
        {
            int[] array1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            List<int> outout = new List<int>();
            foreach (var item in array2)
            {
                if (array1.Contains(item))
                {
                    outout.Add(item);
                }
            }
            Console.WriteLine(String.Join(" ",outout.OrderBy(x=>x)));
        }
    }
}
