using System;
using System.IO;
using System.Linq;

namespace P12_LineNumbers_FileOperations_
{
    public class Program
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("C:\\Users\\EliteBook\\Desktop\\Input.txt");
            StreamWriter writer = new StreamWriter("C:\\Users\\EliteBook\\Desktop\\Output.txt");
            int count = 1;
            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();
                    while (true)
                    {
                        if (line==null)
                        {
                            break;
                        }
                        writer.WriteLine($"Line{count}: {line}({line.Count(x => char.IsLetter(x))})({line.Count(x => char.IsPunctuation(x))})");
                        line = reader.ReadLine();
                        count++;
                    }
                }
            }
        }
    }
}
