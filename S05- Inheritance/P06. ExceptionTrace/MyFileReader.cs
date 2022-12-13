using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


public class MyFileReader
{
    private string path;

    public MyFileReader(string path)
    {
        this.Path = path;
    }

    public string Path
    {
        get { return path; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid Path or File Name.");
            }
            path = value;
        }
    }
    public void ReadAndSum()
    {
        string[] inputFromFile = File.ReadAllLines(this.Path);
        List<int> numbers = new List<int>();
        int row = 0;
        foreach (var item in inputFromFile)
        {
            try
            {
                int currentNum = int.Parse(item);
                numbers.Add(currentNum);
            }
            catch (Exception)
            {

                throw new ArgumentException($"Error: On the line {row}" + $"of the file the value was not in the correct format.");
            }
        }
    }


}

