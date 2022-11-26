using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        Department dp = new Department();
        for (int i = 0; i < count; i++)
        {
            List<string> cmd = Console.ReadLine().Split(" ").ToList();
            Employee n = new Employee(cmd[0], int.Parse(cmd[1]));
            dp.AddMember(n);
        }
        Console.WriteLine(dp.GetOldest());
    }
}

