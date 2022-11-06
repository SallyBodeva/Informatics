using System;


public class Program
{
    static void Main()
    {
        Polidroms();
    }
    public static void Polidroms()
    {
        while (true)
        {
            string cmd = Console.ReadLine();
            if (cmd == "END")
            {
                break;
            }
            string rev = "";
            for (int i = cmd.Length - 1; i > -1; i--)
            {
                rev += cmd[i];
            }
            if (rev == cmd)
            {
                Console.WriteLine("true"); 
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}

