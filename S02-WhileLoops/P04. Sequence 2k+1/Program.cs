using System;

public class Program
{
    static void Main()
    {
       int num = int.Parse(Console.ReadLine());
        int theNum = 1;
        while (theNum<=num)
        {
            Console.WriteLine(theNum);
            theNum = theNum * 2 + 1;
        }
    }
}

