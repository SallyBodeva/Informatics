using System;

namespace P28_ExtractTitle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int startIndex = input.IndexOf("<title>");
            int endIndex = input.LastIndexOf("</title>");
            Console.WriteLine(startIndex);
            Console.WriteLine(endIndex);
            string title = input.Substring(startIndex + 7);
            Console.WriteLine(title);
        }
    }
}
