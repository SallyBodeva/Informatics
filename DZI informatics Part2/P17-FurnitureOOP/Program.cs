using System;
using System.Collections.Generic;
using System.Linq;

namespace P17_FurnitureOOP
{
    internal class Program
    {
        static void Main()
        {
            List<Table> tables = new List<Table>();
            List<Cabinet> cabinets = new List<Cabinet>();
            while (true)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                if (input[0]=="END")
                {
                    break;
                }
                switch (input[0])
                {
                    case "table":
                        double price = double.Parse(input[1]);
                        Table t = new Table("table", price);
                        tables.Add(t);
                        break;
                    case "cabinet":
                        double priceC = double.Parse(input[1]);
                        int hinges = int.Parse(input[2]);
                        Cabinet c = new Cabinet("cabinet", priceC,hinges);
                        cabinets.Add(c);
                        break;
                }
            }
            Console.WriteLine("All tables:");
            foreach (var item in tables)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("All cabinets:");
            foreach (var item in cabinets)
            {
                Console.WriteLine(item.ToString());
            }
        }
       
    }
}
