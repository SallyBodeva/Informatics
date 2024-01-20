using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19_ArrayOperations
{
    public static class ArrayMethods
    {
        public static string PrintArray(string[] array, string separator)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < array.Length-1; i++)
            {
                sb.Append($"{array[i]}{separator}");
            }
            sb.Append(array[array.Length-1]);
            return sb.ToString().TrimEnd();
        }
        public static int[] RandomIntArray(int n, int min, int max)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Random r = new Random();
                array[i] = r.Next(min,max);
            }
            return array;
        }
        public static double[] RandomDoubleArray(int n, int min, int max)
        {
            double[] array = new double[n];
            for (int i = 0; i < n; i++)
            {
                Random r = new Random();
                array[i] = r.NextDouble()+min;
            }
            return array;
        }
        public static bool[] RandomBoolArray(int n)
        {
            bool[] array = new bool[n];
            bool[] trueFalse = { true, false };
            for (int i = 0; i < n; i++)
            {
                Random r = new Random();
                int index = r.Next(0, 2);
                array[i] = trueFalse[index];
            }
            return array;
        }
    }
}
