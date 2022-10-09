using System;

public class Program
{
    static void Main()
    {
        int eggs = int.Parse(Console.ReadLine());
        int soldEggs = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if (input=="Close")
            {
                Console.WriteLine($"Store is closed!");
                Console.WriteLine($"{soldEggs} eggs sold.");
                break;
            }
            int eggsBoughtOrFilled = int.Parse(Console.ReadLine());
            if (input=="Buy")
            {
                if (eggsBoughtOrFilled>eggs)
                {
                    Console.WriteLine($"Not enough eggs in store!");
                    Console.WriteLine($"You can buy only {eggs}.");
                    break;
                }
                eggs -= eggsBoughtOrFilled;
                soldEggs+=eggsBoughtOrFilled;
            }
            if (input=="Fill")
            {
                eggs += eggsBoughtOrFilled;
            }
        }
       
    }
}

