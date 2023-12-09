using System;
using System.Data;
using System.IO;

namespace P05_FilesMethods
{
    internal class Program
    {
        static void Main()
        {
            DeleteFile(@"C:\Users\EliteBook\Desktop\salkaEVelika.txt");
        }
        public static void CreateBlankFile(string fileName)
        {
            File.Create(@$"C:\Users\EliteBook\Desktop\{fileName}.txt");
            Console.WriteLine($"A file created with name {fileName}.txt");
        }
        public static void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("File deleted successfully");
            }
            else Console.WriteLine("File is not found");
        }
    }
}
