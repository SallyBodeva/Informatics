using System;
using System.Data;
using System.IO;

namespace P05_FilesMethods
{
    internal class Program
    {
        static void Main()
        {
        }
        public static void CreateBlankFile(string fileName)
        {
            File.Create(@$"C:\Users\EliteBook\Desktop\{fileName}.txt");
            Console.WriteLine($"A file created with name {fileName}.txt");
        }
    }
}
