using System;
using System.Collections;
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
                Person p = new Person(input[0], input[1], int.Parse(input[2]));
                people.Add(p);
            }
            people.OrderBy(x => x.FirstName).ThenBy(x => x.Age).ToList().ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
}
