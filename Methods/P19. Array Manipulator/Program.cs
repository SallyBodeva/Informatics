using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        while (true)
        {
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            if (commands[0]=="end")
            {
                break;
            }
            switch (commands[0])
            {
                case "exchange":
                    if (int.Parse(commands[1])>(nums.Length-1))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    int[] nums1 = null; ;
                    for (int i = 0; i < int.Parse(commands[1]); i++)
                    {
                        nums1[i] = nums[i];
                    }
                    int[] nums2 = null; ;
                    for (int i = int.Parse(commands[1]); i < nums.Length; i++)
                    {
                        nums2[i] = nums[i];
                    }
                    int []numsExchanged = null;
                    for (int i = 0; i < nums2.Length; i++)
                    {
                        numsExchanged[i] = nums2[i];
                    }
                    for (int i = nums2.Length; i < nums.Length; i++)
                    {
                        numsExchanged[i] = nums1[i];
                    }
                    nums = numsExchanged;
                    break;
                case "max even":
                    int max = int.MinValue;
                    int[] EvenNumsMax = null;
                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (nums[i]%2==0)
                        {
                            EvenNumsMax[i] = nums[i];
                        }
                    }
                    foreach (var item in EvenNumsMax)
                    {

                        if (item > max)
                        {
                            max = item;
                        }
                    }
                    Console.WriteLine(max);
                    break;
                case "min even":
                    int min = int.MaxValue;
                    int[] EvenNumsMin = null;
                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] % 2 == 0)
                        {
                            EvenNumsMin[i] = nums[i];
                        }
                    }
                    foreach (var item in EvenNumsMin)
                    {
                        if (item < min)
                        {
                            min = item;
                        }
                    }
                    Console.WriteLine(min);
                    break;
                case "max odd":
                    int max1 = int.MinValue;
                    int[] OddNumsMax = null;
                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] % 2 == 1)
                        {
                            OddNumsMax[i] = nums[i];
                        }
                    }
                    foreach (var item in OddNumsMax)
                    {

                        if (item > max1)
                        {
                            max1 = item;
                        }
                    }
                    Console.WriteLine(max1);
                    break;
                case "min odd":
                    int min1 = int.MaxValue;
                    int[] OddNumsMin = null;
                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] % 2 == 1)
                        {
                            OddNumsMin[i] = nums[i];
                        }
                    }
                    foreach (var item in OddNumsMin)
                    {

                        if (item < min1)
                        {
                            min1 = item;
                        }
                    }
                    Console.WriteLine(min1);
                    break;
                case "":

                    break;
                default:
                    break;
            }
        }
    }

}

