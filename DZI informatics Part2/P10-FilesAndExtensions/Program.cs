using System;
using System.Collections.Generic;
using System.IO;

namespace P10_FilesAndExtensions
{
    public class Program
    {
        static void Main()
        {
            string dirPath = Console.ReadLine();
            string[] files = Directory.GetFiles(dirPath);
            Dictionary<string, int> filesCount = new Dictionary<string, int>();
            foreach (var file in files)
            {
                int dotIndex = file.LastIndexOf('.');
                string extension = file.Substring(dotIndex);
                if (filesCount.ContainsKey(extension))
                {
                    filesCount[extension]++;
                }
                else
                {
                    filesCount.Add(extension, 1);
                }
            }
            foreach (var item in filesCount)
            {
                Console.WriteLine($"{item.Key} - {item.Value} файла");
            }
        }
    }
}
