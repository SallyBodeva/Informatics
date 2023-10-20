using System;
using System.Linq;

namespace P05_Distances
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double[] nums = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
                Console.WriteLine(Distances.Euclidean(nums[0], nums[1], nums[2], nums[3])); 
            }
        }
    }
}
