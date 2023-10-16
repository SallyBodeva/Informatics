using System;
using System.Linq.Expressions;

namespace P04_MonthsNames
{
    public class Program
    {
        static void Main()
        {
            while (true)
            {
                int sum = 0;
                string letter = Console.ReadLine().ToLower();
                if (!char.IsLetter(letter.ToCharArray()[0]))
                {
                    break;
                }
                if ("january".Contains(letter)) sum++;
                if ("february".Contains(letter)) sum++;
                if ("march".Contains(letter)) sum++;
                if ("april".Contains(letter)) sum++;
                if ("may".Contains(letter)) sum++;
                if ("june".Contains(letter)) sum++;
                if ("july".Contains(letter)) sum++;
                if ("august".Contains(letter)) sum++;
                if ("semptember".Contains(letter)) sum++;
                if ("october".Contains(letter)) sum++;
                if ("november".Contains(letter)) sum++;
                if ("december".Contains(letter)) sum++;
                Console.WriteLine(sum);
            }
        }
    }
}