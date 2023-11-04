using System;
using System.IO;

namespace P13_CopyBinaryFile_FileOperations_
{
    internal class Program
    {
        static void Main()
        {
            FileStream inputFile = new FileStream("C:\\Users\\EliteBook\\Desktop\\10-paris.jpg", FileMode.Open);
            FileStream output = new FileStream("C:\\Users\\EliteBook\\Desktop\\NewFile.jpg", FileMode.CreateNew);
            MemoryStream ms = new MemoryStream();
            using (inputFile)
            {
                inputFile.CopyTo(ms);
            }
            byte[] array = ms.ToArray();
            using (output)
            {
                foreach (var item in array)
                {
                    output.WriteByte(item);
                }
            }
        }
    }
}
