using System;


public class Program
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double length = double.Parse(Console.ReadLine());
        double cake = length * width;
        while (true)
        {
            string cmd = Console.ReadLine();
            if (cmd == "STOP")
            {
                Console.WriteLine($"{cake} pieces are left.");
                break;
            }
            cake -= double.Parse(cmd);
            if (cake < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
                break;
            }
        }

    }
}

