using System;


public class Program
{
    static void Main()
    {
        string gName = Console.ReadLine();
        string sName = Console.ReadLine();
        string lName = Console.ReadLine();
        string bName = Console.ReadLine();

        Gorilla g = new Gorilla(gName);
        Snake s = new Snake(sName);
        Lizard l = new Lizard(lName);
        Bear b = new Bear(bName);
        Console.WriteLine(g);
        Console.WriteLine(s);
        Console.WriteLine(l);
        Console.WriteLine(b);

    }
}

