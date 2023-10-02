using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_Furniture
{
    public class Program
    {
        static void Main()
        {
            List<Furniture> furnitures = new List<Furniture>();
            Furniture f = null;
            while (true)
            {
                string[] commands = Console.ReadLine().Split(" ").ToArray();
                if (commands[0]=="END")
                {
                    break;
                }
                switch (commands[0])
                {
                    case "table":
                        f = new Table(double.Parse(commands[1]));
                        break;
                    case "cabinet":
                        f = new Cabinet(double.Parse(commands[1]), int.Parse(commands[2]));
                        break;
                }
            }
            Console.WriteLine("All tables: ");
            foreach (var item in furnitures)
            {
                if (item.TypeProduct=="table")
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("All cabinets: ");
            foreach (var item in furnitures)
            {
                if (item.TypeProduct == "cabinet")
                {
                    Console.WriteLine(item);
                }
            }
        }
        //To dooo
    }
}
