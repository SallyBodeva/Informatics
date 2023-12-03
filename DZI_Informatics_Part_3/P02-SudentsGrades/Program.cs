using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace P02_SudentsGrades
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, double> grades = new Dictionary<string, double>();
            StreamReader reader = new StreamReader(@"C:\Users\EliteBook\Desktop\input.txt");
            StreamWriter writer = new StreamWriter(@"C:\Users\EliteBook\Desktop\output.txt");
            using (reader)
            {
                string line = string.Empty;
                while ((line= reader.ReadLine())!=null)
                {
                    string[] data = line.Split("-");
                    string studentName = data[0];
                    double grade = double.Parse(data[1]);
                    grades.Add(studentName, grade);
                }
            }
            using (writer)
            {
                foreach (var item in grades.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    writer.WriteLine($"{item.Key} {item.Value}");
                }
            }
        }
    }
}
