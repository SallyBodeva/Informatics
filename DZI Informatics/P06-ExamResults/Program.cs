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
            int countL = 0;
            List<double> validPoints = new List<double>();
            for (int i = 0; i < n; i++)
            {
                double result = double.Parse(Console.ReadLine());
                validPoints = ReadPints(validPoints, result);
            }
            double min = MinimalDifference(validPoints);
            for (int i = 0; i < validPoints.Count; i++)
            {
                foreach (double point in FindLaureants(validPoints))
                {
                    if (validPoints[i]>=point)
                    {
                        countL++;
                    }
                }
            }
            Console.WriteLine($"valid works - {validPoints.Count}");
            Console.WriteLine($"minimal difference - {min:f3} p.");
            Console.WriteLine($"laureates - {countL}");
        }
        
        private static List<double> ReadPints(List<double> vP, double result)
        {
            if (result > 0)
            {
                vP.Add(result);
            }

            return vP.OrderBy(x => x).ToList();
        }
        public static double MinimalDifference(List<double> result )
        {
            List<double> differences = new List<double>();
            for (int i = 0; i < result.Count; i++)
            {
                differences.Add(result[i] - result[i + 1]);
            }
            return differences.OrderBy(x => x).ToList().FirstOrDefault();
        }
        public static List<double> FindLaureants(List<double> result)
        {
            return result.OrderByDescending(x => x).Take(3).ToList();
        }
        // TO DO
    }
}
