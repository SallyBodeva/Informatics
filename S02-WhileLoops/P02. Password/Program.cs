using System;


public class Program
{
    static void Main()
    {
        string username = Console.ReadLine();
        string password = Console.ReadLine();
        string cmd = null;
        while ((cmd=Console.ReadLine())!=password)
        {

        }
        Console.WriteLine($"Welcome {username}!");
    }
}

