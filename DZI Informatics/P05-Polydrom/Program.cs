using System;
using System.Linq;

namespace P05_Polydrom
{
    public class Program
    {
        static void Main()
        {
            string num = Console.ReadLine();
            int n = 0;
            int indexMiddle = 0;
            try
            {
                n = int.Parse(num);
                if (n < 0)
                {
                    Console.WriteLine("Incorrectly entered number"); 
                    Environment.Exit(0);
                }
            }
            catch
            {
                Console.WriteLine("Incorrectly entered number");
                Environment.Exit(0);
            }
            if (n % 2 == 0)
            {
                indexMiddle = (num.Length / 2) - 1;
            }
            else
            {
                indexMiddle = num.Length / 2;
            }

            string firstPart = num.Substring(0,(num.Length-indexMiddle));
            string seconfPart = new string(num.Substring(indexMiddle, num.Length - (indexMiddle)).Reverse().ToArray());
            if (firstPart==seconfPart)
            {
                Console.WriteLine($"{num} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{num} is NOT a palindrome");
            }
        }
    }
}
