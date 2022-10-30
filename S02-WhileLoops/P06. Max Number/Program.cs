using System;


public class Program
{
    static void Main()
    {
        string cmd = null;
        int max = int.MinValue;
        while ((cmd=Console.ReadLine())!="Stop")
        {
            if (int.Parse(cmd)>max)
            {
                max = int.Parse(cmd);
            }
        }
        Console.WriteLine(max);
    }
}

