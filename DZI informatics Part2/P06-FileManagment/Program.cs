using System;
using System.IO;
using System.Linq;

namespace P06_FileManagment
{
    internal class Program
    {
        static void Main()
        {
            string docPath = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string[] filesData = null;
            DirectoryInfo d = new DirectoryInfo(docPath);
            for (int i = 0; i < n; i++)
            {
                filesData = Console.ReadLine().Split(" - ");
                var folderName = Path.Combine(Path.GetTempPath(), filesData[1]);
                DirectoryInfo subDirectory = d.CreateSubdirectory(folderName);
                var files = d.GetFiles();
                foreach (var file in files)
                {
                    if (file.Name.Substring(file.Name.Length - 4) == filesData[0])
                    {
                        File.Copy(file.FullName, folderName, true);
                    }
                }
            }
            foreach (var dir in d.GetDirectories())
            {
                Console.WriteLine(dir.FullName);
                Console.WriteLine(dir.GetDirectories().Count());
            }
        }
    }
}
