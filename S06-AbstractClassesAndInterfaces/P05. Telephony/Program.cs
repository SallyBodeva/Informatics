using System;


public class Program
{
    static void Main()
    {
        string[] dataNums = Console.ReadLine().Split(' ');
        string[] dataSites = Console.ReadLine().Split(' ');
        bool invalidNum=false;
        bool invaldSite = false;
        foreach (var item in dataNums)
        {
            foreach (var digit in item)
            {
                if (!char.IsDigit(digit))
                {
                    Console.WriteLine("Invalid number!");
                    invalidNum = true;
                }
            }
            if (invalidNum==false)
            {
                if (item.Length == 7)
                {
                    IStationaryPhone stationaryPhone = new StationaryPhone(item);
                    stationaryPhone.Calling();
                }
                else if (item.Length == 10)
                {
                    ISmartphone smartphone = new Smartphone(item);
                    smartphone.Calling();
                }
            }
        }
        foreach (var site in dataSites)
        {
            foreach (var letter in site)
            {
                if (char.IsDigit(letter))
                {
                    Console.WriteLine("Invalid URL!");
                    invaldSite = true;
                }
            }
            if (invaldSite==false)
            {
                Smartphone sm = new Smartphone();
                sm.URL = site;
                sm.Browsing();
            }
        }
    }
}

