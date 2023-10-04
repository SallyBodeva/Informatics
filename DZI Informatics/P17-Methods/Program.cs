using System;
using System.Collections.Generic;
using System.Linq;

namespace P17_Methods
{
    public class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Console.WriteLine(String.Join(" ",DividedByK(list,3)));
        }
        public static List<int> DividedByK(List<int> list, int k)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int n = list[i];
                int sumN = 0;
                while (n > 0)
                {
                    sumN += n % 10;
                    n /= 10;
                }
                if (sumN % k == 0)
                {
                    list.RemoveAt(i);
                }
            }
            return list;
        }
       
    }
}
