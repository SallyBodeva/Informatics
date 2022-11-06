using System;

public class Program
{
    static void Main()
    {
        string words = Console.ReadLine();
        int times = int.Parse(Console.ReadLine());
        RepeatString(words, times);
    }
    public static void RepeatString(string words, int n)
    {
        string repeat = null;
        for (int i = 0; i < n; i++)
        {
            repeat += words;
        }
        Console.WriteLine(repeat);
    }
}
