using System;


public class Program
{
    static void Main()
    {
        string cmd = null;
        while ((cmd=Console.ReadLine())!="Stop")
        {
            Console.WriteLine(cmd);
        }
    }
}

