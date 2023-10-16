using System;
using System.Collections.Generic;
using System.Text;

namespace P05_Distances
{
    public static class Distances
    {
        public static double Euclidean(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
        public static double Manhattan(double x1, double x2, double y1, double y2)
        {
            return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
        }
        public static double Chebyshev(double x1, double x2, double y1, double y2)
        {
            return Math.Max(Math.Abs(x1 - x2), Math.Abs(y1 - y2));
        }
    }
}
