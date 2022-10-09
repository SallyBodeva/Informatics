using System;
public class Program
{
    static void Main()
    {
        int eggsFirst = int.Parse(Console.ReadLine());
        int eggsSecond = int.Parse(Console.ReadLine());
        while (true)
        {
            string input = Console.ReadLine();
            if (input=="End")
            {

                Console.WriteLine($"Player one has {eggsFirst} eggs left.");
                Console.WriteLine($"Player two has {eggsSecond} eggs left.");
                break;
            }
            if (input == "one")
            {
                eggsSecond--;
            }
            if (input == "two")
            {
                eggsFirst--;
            }
            if (eggsFirst == 0)
            {
                Console.WriteLine($"Player one is out of eggs. Player two has {eggsSecond} eggs left.");
                break;
            }
            else if (eggsSecond==0)
            {
                Console.WriteLine($"Player two is out of eggs. Player one has {eggsFirst} eggs left.");
                break;
            }     
        }
    }
}

