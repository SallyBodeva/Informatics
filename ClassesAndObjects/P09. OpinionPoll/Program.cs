using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Employee> employees = new List<Employee>();
        List<Employee> employeesOver30 = new List<Employee>();
        for (int i = 0; i < n; i++)
        {
            List<string> data = Console.ReadLine().Split(" ").ToList();
            Employee employee = new Employee(data[0], int.Parse(data[1]));
            employees.Add(employee);
        }
        foreach (var em in employees)
        {
            if (em.Age > 30)
            {
                employeesOver30.Add(em);
            }
        }
        foreach (var item in employeesOver30.OrderBy(x => x.Name).ToList())
        {
            Console.WriteLine(item);
        }
    }
}

