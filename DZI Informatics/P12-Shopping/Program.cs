using System;
using System.Collections.Generic;
using System.Linq;

namespace P12_Shopping
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, double> shopping = new Dictionary<string, double>();
            double sum = 0;
            while (true)
            {
                string[] data = Console.ReadLine().Split("-").ToArray();
                if (data[0] == "Stop shopping")
                {
                    break;
                }
                if (shopping.ContainsKey(data[0]))
                {
                    shopping[data[0]] += double.Parse(data[1]);
                }
                else
                {
                    shopping.Add(data[0], double.Parse(data[1]));
                }
            }
            foreach (var item in shopping.OrderBy(x=>x.Value))
            {
                sum += item.Value;
                Console.WriteLine($"{item.Key}->{item.Value:f2}");
            }
            Console.WriteLine($"Total sum: {sum:f2}");

        }
    }
}
