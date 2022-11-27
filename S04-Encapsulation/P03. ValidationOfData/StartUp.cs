using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PersonsInfo
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string message = string.Empty;
            int count = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < count; i++)
            {

                List<string> data = Console.ReadLine().Split(' ').ToList();
                try
                {
                    Person p = new Person(data[0], data[1], int.Parse(data[2]), decimal.Parse(data[3]));
                    people.Add(p);

                }
                catch (Exception ex)
                {
                    message = ex.Message;
                    Console.WriteLine(message);
                }
            }
            var per = decimal.Parse(Console.ReadLine());
            foreach (var item in people)
            {
                item.IncreaseSalary(per);
                Console.WriteLine(item);
            }
            
        }
    }
}
