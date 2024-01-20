using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace P19_ArrayOperations
{
    internal class Program
    {
        static void Main()
        {
            string[] test = { "test1", "test2", "test3" };
            Console.WriteLine(string.Join(", ",ArrayMethods.RandomBoolArray(15)));
        }

        private static void CommonElements()
        {
            string[] array1 = Console.ReadLine().Split(" ").ToArray();
            string[] array2 = Console.ReadLine().Split(" ").ToArray();
            StringBuilder sb = new StringBuilder();
            foreach (var item in array1)
            {
                if (array2.Contains(item))
                {
                    sb.Append($"{item} ");
                }
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }

        private static void CondenseArrayToNumber()
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] newNums = new int[nums.Length - 1];
            while (nums.Length > 1)
            {
                for (int i = 0; i < newNums.Length; i++)
                {
                    newNums[i] = nums[i] + nums[i + 1];
                }
                nums = newNums;
                newNums = new int[nums.Length - 1];
            }
            Console.WriteLine(nums.Sum());
        }

        private static void EqualArrays()
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] nums2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            bool isIdentical = true;
            for (int i = 0; i < nums.Length; i++)
            {
                try
                {
                    if (nums[i] != nums2[i])
                    {
                        isIdentical = false;
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isIdentical = false;
                    break;
                }
            }
            if (isIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {nums.Sum()}");
            }
        }

        private static void EvenAndOddSubtraction()
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int evenSum = nums.Where(x => x % 2 == 0).Sum();
            int oddSum = nums.Where(x => x % 2 == 1).Sum();

            Console.WriteLine(evenSum - oddSum);
        }

        private static void SumEvenNumbers()
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    sum += nums[i];
                }
            }
            Console.WriteLine(sum);
        }

        private static void ReverseArrayOfStrings()
        {
            string[] words = Console.ReadLine().Split(" ").ToArray();
            string[] reversedWords = new string[words.Length];
            int insertIndex = 0;
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversedWords[insertIndex] = words[i];
                insertIndex++;
            }
            Console.WriteLine(string.Join(" ", reversedWords));
        }

        private static void RoundingNumbers()
        {
            double[] nums = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{nums[i]}->{Math.Round(nums[i])}");
            }
        }
    }
}
