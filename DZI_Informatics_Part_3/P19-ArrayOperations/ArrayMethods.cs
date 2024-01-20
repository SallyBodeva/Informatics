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
        public static int MaxElement(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        public static int SecondMaxElement(int[] array)
        {
            int max = int.MinValue;
            int secondMax = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    secondMax = max;
                    max = array[i];
                }
                else if (array[i] > secondMax && array[i] < max)
                {
                    secondMax = array[i];
                }
            }
            return secondMax;
        }
        public static double AverageValue(int[] array)
        {
            int length = array.Length;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return (double)sum / length;
        }
        public static int SumOfAbsValues(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>=0)
                {
                    sum += array[i];
                }
                else
                {
                    sum += array[i] * (-1);
                }
            }
            return sum;
        }

    }
}
