using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_PersonalNumsSort
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<KeyValuePair<int,int>> pairs = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                KeyValuePair<int,int> keyValuePair = new KeyValuePair<int,int>(input[0],input[1]);
                pairs.Add(keyValuePair);
            }
            foreach (var item in pairs.OrderBy(x=>x.Key).ThenBy(x=>x.Value))
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}
