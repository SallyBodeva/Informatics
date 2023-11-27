using System;
using System.Linq;

namespace P26_SameReverse
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            char[] reversed = input.ToCharArray().Reverse().ToArray();
            string output = new string(reversed);
            if (input== output)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Не");
            }
        }
    }
}
