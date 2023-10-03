using System;
using System.Collections.Generic;
using System.Linq;

namespace P15_NumbersCount
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> nums = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (nums.ContainsKey(number))
                {
                    nums[number] += 1;
                }
                else
                {
                    nums.Add(number, 1);
                }
            }
            foreach (var item in nums.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"число: {item.Key}, брой: {item.Value}");
            }
        }
    }
}
