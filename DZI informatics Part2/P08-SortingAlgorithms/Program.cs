using System;

namespace P08_SortingAlgorithms
{
    internal class Program
    {
        static void Main()
        {
            int[] example = new int[] { 6, 1, 0, 19, -2 };
            Console.WriteLine(String.Join(" ",InsertionSort(example)));
        }

        public static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j <array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Swap(array, i, j);
                    }
                }
            }
            return array;
        }

        private static void Swap(int[] array, int i, int j)
        {
            int firstElement = array[i];
            array[i] = array[j];
            array[j] = firstElement;
        }

        public static int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        Swap(array, i, j);
                    }
                }
            }
            return array;
        }
        public static int[] InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i-1>=0)
                {
                    while (array[i] < array[i - 1])
                    {
                        Swap(array, i, i - 1);
                    }
                }
            }
            return array;
        }
    }
}
