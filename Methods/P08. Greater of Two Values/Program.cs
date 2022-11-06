using System;

public class Program
{
    static void Main()
    {
        string cmd = Console.ReadLine();
        switch (cmd)
        {
            case "int":
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                GetMaxINT(a, b);
                break;
            case "char":
                char a1 = char.Parse(Console.ReadLine());
                char b1 = char.Parse(Console.ReadLine());
                GetMaxChar(a1, b1);
                break;
            case "string":
                string a2 = Console.ReadLine();
                string b2 = Console.ReadLine();
                GetMaxString(a2, b2);
                break;
        }

    }
    public static void GetMaxINT(int a, int b)
    {
        if (a>b)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
        }
    }
    public static void GetMaxChar(char a, char b)
    {
        if (a > b)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
        }
    }
    public static void GetMaxString(string a, string b)
    {
        int sumA = 0;
        int sumB = 0;
        foreach (var letters in a)
        {
            int letterWorth = letters - '0';
            sumA += letterWorth;
        }
        foreach (var letters in b)
        {
            int letterWorth = letters - '0';
            sumB += letterWorth;
        }
        if (sumA>sumB)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
        }
    }
}

