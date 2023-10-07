using System;


public class Program
{
    static void Main()
    {
        string favouriteBook = Console.ReadLine();
        int counter = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if (input==favouriteBook)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
                break;
            }
            if (input== "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
                break;
            }
            counter++;
        }
        // 123
    }
}

