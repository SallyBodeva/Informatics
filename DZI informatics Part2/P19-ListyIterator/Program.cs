using System;
using System.Collections.Generic;

namespace P19_ListyIterator
{
    internal class Program
    {
        static void Main()
        {
            ListyIterator<string> list = null;
            while (true)
            {
                string[] commands = Console.ReadLine().Split(' ');
                if (commands[0] == "END")
                {
                    break;
                }
                switch (commands[0])
                {
                    case "Create":
                        List<string> elements = new List<string>();
                        if (commands.Length > 1)
                        {
                            for (int i = 1; i < commands.Length; i++)
                            {
                                elements.Add(commands[i]);
                            }
                        }
                        list = new ListyIterator<string>(elements);
                        break;
                    case "HasNext":
                        Console.WriteLine(list.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(list.Move());
                        break;
                    case "Print":
                        list.Print();
                        break;
                    case "Print all":
                        list.PrintAll();
                        break;
                }
            }
        }
    }
}
