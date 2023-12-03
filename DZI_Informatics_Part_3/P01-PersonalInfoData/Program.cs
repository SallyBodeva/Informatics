using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace P01_PersonalInfoData
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, int> citiesCount = new Dictionary<string, int>();
            StreamReader reader = new StreamReader("C:\\Users\\EliteBook\\Desktop\\input.txt");
            using (reader)
            {
                string line = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    int cityNameIndex = line.LastIndexOf('-');
                    string cityName = line.Substring(cityNameIndex + 2);
                    if (citiesCount.ContainsKey(cityName))
                    {
                        citiesCount[cityName]++;
                    }
                    else
                    {
                        citiesCount.Add(cityName, 1);
                    }
                }
            }
            KeyValuePair<string, int> theCity = citiesCount.OrderByDescending(x => x.Value).First();
            Console.WriteLine($"{theCity.Key} {theCity.Value}");
        }
    }
}
