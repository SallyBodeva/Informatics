using System;
using System.Collections.Generic;

namespace P03_LuckyNums
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> coolNums = new List<string>();
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        for (int l = 0; l <= 9; l++)
                        {
                            if (i + l == n && j % 2 == 1 && (k == 4 || k == 7))
                            {
                                coolNums.Add($"{i}{j}{k}{l}");
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ",coolNums));
        }
    }
}
