using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

public class Program
{
    static void Main()
    {
        List<Citizen> citizens = new List<Citizen>();
        List<Pet> pets = new List<Pet>();
        List<string> correctYear = new List<string>();
        while (true)
        {
            string[] data = Console.ReadLine().Split(' ');
            if (data[0]=="End")
            {
                break;
            }
            if (data[0]=="Citizen")
            {
                Citizen c = new Citizen(data[1], int.Parse(data[2]), data[3], data[4]);
                citizens.Add(c);
            }
            if (data[0]=="Pet")
            {
                Pet p = new Pet(data[1], data[2]);
                pets.Add(p);
            }
        }
        string corrBirthday = Console.ReadLine();
        foreach (var item in citizens)
        {
            string birthadayYear = item.Birthday.Split('/').LastOrDefault().ToString();
            if (birthadayYear==corrBirthday)
            {
                correctYear.Add(item.Birthday);
            }
        }
        foreach (var item in pets)
        {
            string birthadayYear = item.Birhday.Split('/').LastOrDefault().ToString();
            if (birthadayYear == corrBirthday)
            {
                correctYear.Add(item.Birhday);
            }
        }
        foreach (var item in correctYear)
        {
            Console.WriteLine(item);
        }
    }
}

