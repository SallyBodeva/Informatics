using System;

namespace P27_ForbiddenWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] forbiddenWords = Console.ReadLine().Split(", ");
            foreach (var word in forbiddenWords)
            {
                if (input.Contains(word))
                {
                    input= new string(input.Replace(word,"***"));
                }
            }
            Console.WriteLine(input);
        }
    }
}
