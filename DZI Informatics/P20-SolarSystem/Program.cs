
using System;
using System.Collections.Generic;
using System.Linq;

namespace P20_SolarSystem
{
    public class Program
    {
        static void Main()
        {
            Star star1 = new Star("Pink",2.1,2,8.2,"MilkyWay");
            Star star2 = new Star("Blue", 5.1, 4, 19.0, "MilkyWay1");
            Star star3 = new Star("White", 9.1, 9, 4.1, "MilkyWay2");
            Star star4 = new Star("Red", 0.8, 7, 9.0, "MilkyWay2");
            Star star5 = new Star("Green", 8.89, 8, 5.1, "MilkyWay4");

            List<Star> stars = new List<Star>() {star1,star2,star3,star4,star5};
           
            Console.WriteLine(string.Join("\n", AverageWeightInConstellation(stars)));
        }
        public static List<string> SortedStars(List<Star> list)
        {
            List<string> output = new List<string>();
            foreach (var item in list.OrderBy(x=>x.Distance))
            {
                string text = StarInfo(item);
                output.Add(text);
            }
            return output;
        }
        public static List<string> SortByConstellation(List<Star> list)
        {
            List<string> output = new List<string>();
            foreach (var item in list.OrderBy(x=>x.Constellation).ThenByDescending(x=>x.Distance))
            {
                string text = StarInfo(item);
                output.Add(text);
            }
            return output;
        }
        public static List<string> AverageWeightInConstellation(List<Star>list)
        {
            List<string> output = new List<string>();
            HashSet<string> constellationNamesHS = new HashSet<string>();
            list.ForEach(x => constellationNamesHS.Add(x.Constellation));
            List<string> constellationNamesL = constellationNamesHS.ToList();
            for (int i = 0; i < constellationNamesL.Count; i++)
            {
                output.Add($"{constellationNamesL[i]} -> {list.Where(x => x.Constellation == constellationNamesL[i]).Average(x => x.Weight):f2}");
            }
            return output;
        }
        private static string StarInfo(Star item)
        {
            return $"{item.Name}, {item.Distance} св.г., {ReturnName(item.Classification)}, {item.Weight} сл.м., {item.Constellation}";
        }
        
        public static string ReturnName(int n)
        {
            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                 {1, "Хипергигант"},
                 {2, "Свръхгигант"},
                 {3, "Ярки Гигант"},
                 {4, "Гигант"},
                 {5, "Субгигант"},
                 {6, "Джудже"},
                 {7, "Субджудже"},
                 {8, "Червени Джудже"},
                 {9, "Кафяви Джудже"}
            };
            return names[n];
        }
    }
}