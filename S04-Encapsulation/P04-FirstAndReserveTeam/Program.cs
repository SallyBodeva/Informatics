using PersonsInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

public class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        List<Person> people = new List<Person>();
        Team t = new Team();
        for (int i = 0; i < count; i++)
        {
            string[] data = Console.ReadLine().Split(' ').ToArray();
            Person p = new Person(data[0], data[1], int.Parse(data[2]), decimal.Parse(data[3]));
            people.Add(p);
        }
        foreach (var item in people)
        {
            t.AddPerson(item);
        }
        Console.WriteLine($"First team has {t.firstTeam.Count} players.");
        Console.WriteLine($"Reserve team has {t.reserveTeam.Count} players.");
    }
}

