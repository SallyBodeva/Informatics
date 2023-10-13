using System;

namespace P25_SumOfElementsOfArray
{
    public class Program
    {
        static void Main()
        {
            int[] array = new int[70];
            int index = 0;
            while (index!=70)
            {
                Random r = new Random();
                int number = r.Next(-200, 200);
                if (!ContainsElement(array, number))
                {
                    array[index] = r.Next(-200, 200);
                    index++;
                }
            }
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>MinElement(array) && array[i]<MaxElement(array))
                {
                    sum += array[i];
                }
            }
        }
        public static bool ContainsElement(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==target)
                {
                    return true;
                }
            }
            return false;
        }
        public static int MinElement(int[] array)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        public static int MaxElement(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >max )
                {
                    max = array[i];
                }
            }
            return max;
        }
    }
}
