using System;

public class Program
{
    static void Main()
    {

        string cmd = null;
        int min = int.MaxValue;
        while ((cmd = Console.ReadLine()) != "Stop")
        {
            if (int.Parse(cmd) < min)
            {
                min = int.Parse(cmd);
            }
        }
        Console.WriteLine(min);
    }
}

