using System;


public class Program
{
    static void Main()
    {
        RandomList list = new RandomList();
        list.Add("Bond");
        list.Add("Lind");
        list.Add("Nyle");
        list.Add("Parker");

        Console.WriteLine(list.Count);
        Console.WriteLine(list.RandomString());
        Console.WriteLine(list.Count);
    }
}

