using System;
using System.IO;

public class Program
{
    static void Main()
    {
        string inputFilePath = "C:\\Users\\EliteBook\\Desktop\\Input.txt";
        string outputFilePath = "C:\\Users\\EliteBook\\Desktop\\Output.txt";
        StreamReader streamReader = new StreamReader(inputFilePath);
        StreamWriter streamWriter = new StreamWriter(outputFilePath);
        using (streamReader)
        {
            string line = streamReader.ReadLine();
            int count = 0;
            using (streamWriter)
            {
                while (line != null)
                {
                    if (count % 2 == 1)
                    {
                        streamWriter.WriteLine(line);
                    }
                    count++;
                    line = streamReader.ReadLine();
                }
            }
        }
        //Done

    }

}

