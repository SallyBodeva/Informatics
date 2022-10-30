using System;
public class Program
{
    static void Main()
    {
        decimal sum = 0;
        string cmd = null;
        while ((cmd=Console.ReadLine())!= "NoMoreMoney")
        {
            if (decimal.Parse(cmd)<0)
            {
                Console.WriteLine("Invalid operation!");
                break;
            }
            sum += decimal.Parse(cmd);
            Console.WriteLine($"Increase: {decimal.Parse(cmd):f2}");
            
        }
        Console.WriteLine($"Total: {sum:f2}");
    }
}

