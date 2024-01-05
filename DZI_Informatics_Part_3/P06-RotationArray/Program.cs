using System;
using System.Linq;

namespace P06_RotationArray
{
    public class Program
    {
        static void Main()
        {
            //helllo world
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int index = 0;
            int lastIndex = array.Length;
            for (int i = 0; i < n; i++)
            {
                int firstElement = array[index];
                array[index] = array[lastIndex - 1];
                array[lastIndex- 1] = firstElement;
                if (index <= array.Length - 1) index++;
                else index = 0;
                if (lastIndex-- < 0) lastIndex = 0;
                else lastIndex--;
            }
            for (int i = 0; i < array.Length-1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine(array[array.Length-1]);
        }
    }
}
