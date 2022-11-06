using System;


public class Program
{
    static void Main(string[] args)
    {
        string password = Console.ReadLine();
        MiddlePart(password);
    }
    static public void MiddlePart(string word)
    {
        if (word.Length%2==0)
        {
            int middle = word.Length / 2;
            char middleLetter1= word[middle-1];
            char miidleLetter2 = word[middle];
            Console.Write(middleLetter1);
            Console.Write(miidleLetter2);
        }
        else
        {
            int middle = word.Length / 2;
            char middleLetter = word[middle];
            Console.WriteLine(middleLetter);
        }
    }

}

