using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    internal class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                Person p = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));
                people.Add(p);
            }
            decimal per = decimal.Parse(Console.ReadLine());
            foreach (var item in people)
            {
                item.IncreaseSalary(per);
                Console.WriteLine(item);
            }
        }
    }
}
