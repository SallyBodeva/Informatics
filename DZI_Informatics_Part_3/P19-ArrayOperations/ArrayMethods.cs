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
        public static int SumOfDividedBy3AndGreater15(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%3==0 && array[i]>15)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
        public static int[] ArrayOfElementsDivided3Greater15(int[] array)
        {
            int length = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%3==0 && array[i]>15)
                {
                    length ++;
                }
            }
            int[] newArray = new int[length];
            int insertIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0 && array[i] > 15)
                {
                    newArray[insertIndex] = array[i];
                    insertIndex++;
                }
            }
            return newArray;
        }
        public static int AbsValueGreaterAvg(int[] array)
        {
            int count = 0;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double avgValue = (double)sum /array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>=0 && array[i]>avgValue)
                {
                    count++;
                }
                else if (array[i] < 0 && array[i]*(-1) > avgValue)
                {
                    count++;
                }
            }
            return count;
        }
        public static int[] AbsValueGreaterAvgArray(int[] array)
        {
            int count = 0;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double avgValue = (double)sum / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0 && array[i] > avgValue)
                {
                    count++;
                }
                else if (array[i] < 0 && array[i] * (-1) > avgValue)
                {
                    count++;
                }
            }
            int[] newArray = new int[count];
            int insertIndex = 0;
            foreach (var item in array)
            {
                if (item>0&&item>avgValue || item<0 && item*(-1)>avgValue)
                {
                    newArray[insertIndex] = item;
                    insertIndex++;
                }
            }
            return newArray;
        }
        public static int[] TwoArrays(int[] array1, int[] array2)
        {
            int[] newArray = new int[array1.Length + array2.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                newArray[i] = array1[i];
            }
            int insertIndex = array1.Length;
            for (int i = array2.Length - 1; i >= 0; i--)
            {
                newArray[insertIndex] = array2[i];
                insertIndex++;
            }
            return newArray;
        }
        public static int[] SumOFTwoArrays(int[] array1, int[] array2)
        {
            int[] newArray = new int[array1.Length];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array1[i] + array2[i];
            }
            return newArray;
        }
        public static int[] UpTo10(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = 10 - array[i];
            }
            return newArray;
        }
        public static int[] IncreasedWithN(int n,int[] array1, int[] array2)
        {
            int[] newArray = new int[array1.Length+array2.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                newArray[i] = array1[i] + n;
            }
            int insertIndex = array1.Length;
            for (int i = 0; i < array2.Length; i++)
            {
                newArray[insertIndex] = array2[i] + n;
                insertIndex++;
            }
            return newArray;
        }
    }
}
