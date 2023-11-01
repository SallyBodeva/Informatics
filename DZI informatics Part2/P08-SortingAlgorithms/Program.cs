using System;

namespace P08_SortingAlgorithms
{
    internal class Program
    {
        static void Main()
        {
            int[] example = new int[] { 6, 1, 0, 19, -2 };
            Console.WriteLine(String.Join(" ",BubbleSort(example)));
        }

        public static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j <array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int firstElement = array[i];
                        array[i] = array[j];
                        array[j] = firstElement;
                    }
                }
            }
            return array;
        }
    }
}
