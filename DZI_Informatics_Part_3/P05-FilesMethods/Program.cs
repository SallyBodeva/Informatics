using System;
using System.Data;
using System.IO;

namespace P05_FilesMethods
{
    internal class Program
    {
        static void Main()
        {
            EditExistingFile(@"C:\Users\EliteBook\Desktop\sally.txt");
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
        public static void CreateFileWithContent(string path)
        {
            StreamWriter sT = File.CreateText(path);
            using (sT)
            {
                sT.WriteLine("I am 18 years old");
                sT.WriteLine("My favourite colour is blue");
            }
        }
        public static void CreateFileRead(string path)
        {
            StreamWriter st = File.CreateText(path);
            using (st)
            {
                st.WriteLine("Here is the content of the file mytest.txt :");
                st.WriteLine("Hello and Welcome");
            }
            string[] readInfo = File.ReadAllLines(path);
            Console.WriteLine(string.Join("",readInfo));
        }
        public static void EditExistingFile(string path)
        {
            StreamWriter fs = new StreamWriter(path,true);
            using (fs)
            {
                fs.WriteLine("\nThis is the line appended at last line.");
            }
        }
    }
}
