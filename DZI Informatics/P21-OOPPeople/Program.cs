using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace P21_OOPPeople
{
    public class Program
    {
        static void Main()
        {
            List<Human> people = new List<Human>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("First name:");
                string firstName = Console.ReadLine();
              
                Console.Write("Last name:");
                string lastName = Console.ReadLine();
             
                Console.Write("Age:");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Your choice[s - student] , [w - worker]:");
                string type = Console.ReadLine();
                switch (type)
                {
                    case "w":
                        Console.Write("Wage:");
                        double wage = double.Parse(Console.ReadLine());

                        Console.Write("Hours worked:");
                        int workHours = int.Parse(Console.ReadLine());

                        Worker w = new Worker(wage,workHours,firstName,lastName,age);
                        people.Add(w);
                        break;
                    case "s":
                        Console.Write("Grade:");
                        double grade = double.Parse(Console.ReadLine());

                        Student s = new Student(grade,firstName,lastName,age);
                        people.Add(s);
                        break;
                }
            }
            foreach (var item in people)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}