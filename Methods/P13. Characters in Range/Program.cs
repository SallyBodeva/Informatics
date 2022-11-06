using System;


public class Program
{
    static void Main()
    {
        char a = char.Parse(Console.ReadLine());
        char b = char.Parse(Console.ReadLine());
        PrintBetwwen(a, b);
    }
    public static void PrintBetwwen(char a, char b)
    {
        int chislo_a = (int)a;
        int chislo_b = (int)b;
        if (chislo_a<chislo_b)
        {
            for (int i = chislo_a + 1; i < chislo_b; i++)
            {
                Console.Write((char)i + " ");
            }
        }
        else
        {
            for (int i = chislo_b + 1; i < chislo_a; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}

