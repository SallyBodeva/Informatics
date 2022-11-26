using System;
using System.Collections.Generic;
using System.Linq;


    public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Driver> drivers = new List<Driver>();
        Driver drBestTime = null;
        for (int i = 0; i < n; i++)
        {
            List<string> cmd = Console.ReadLine().Split(' ').ToList();
            Driver driver = new Driver(cmd[0] + " " + cmd[1], int.Parse(cmd[2]), float.Parse(cmd[3]), float.Parse(cmd[4]));
            drivers.Add(driver);
        }
        foreach (var item in drivers)
        {
            drBestTime = drivers.OrderBy(x => x.TotalTime).First();
        }
        Console.WriteLine(drBestTime);
    }
}

