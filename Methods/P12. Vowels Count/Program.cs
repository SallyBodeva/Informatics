using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        string a = Console.ReadLine();
        PrintTheCount(a);
    }
    public static void PrintTheCount(string a)
    {
        int vowelCount = 0;
        foreach (var letter in a)
        {
            switch (letter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    vowelCount++;
                    break;
            }
        }
        Console.WriteLine(vowelCount);
    }
}

