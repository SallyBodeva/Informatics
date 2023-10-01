using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_ExamResults
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<double> validResults = ReadValidPoints(n);
            double min = MinDiff(validResults);
            int laureatesCount = Laureates(validResults);

            Console.WriteLine($"valid works - {validResults.Count}");
            Console.WriteLine($"minimal difference - {min:f3} p.");
            Console.WriteLine($"laureates - {laureatesCount}");
        }
        public static List<double> ReadValidPoints(int n)
        {
            List<double> valid = new List<double>();
            for (int i = 0; i < n; i++)
            {
                double result = double.Parse(Console.ReadLine());
                if (result>0)
                {
                    valid.Add(result);
                }
            }
            return valid;
        }
        public static double MinDiff(List<double> list)
        {
            double min = double.MaxValue;
            for (int i = 0; i < list.Count-1; i++)
            {
                if ((list[i + 1] - list[i])<min)
                {
                    min = (list[i + 1] - list[i]);
                }
            }
            if ((list[list.Count-1]- list[list.Count - 2])<min)
            {
                min = (list[list.Count - 1] - list[list.Count - 2]);
            }
            return min;
        }
        public static int Laureates(List<double> list)
        {
            List<double> maxResults = list.OrderByDescending(x => x).Distinct().Take(3).ToList();
            int count = 0;
            foreach (var item in list)
            {
                if (maxResults.Contains(item))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
