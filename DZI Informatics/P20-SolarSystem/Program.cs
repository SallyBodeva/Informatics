
using System;
using System.Collections.Generic;
using System.Linq;

namespace P20_SolarSystem
{
    public class Program
    {
        static void Main()
        {
            List<Star> stars = new List<Star>()
            {
              new Star("Test",2.1,Classification.,500,"Milky Way"),
              new Star("Test1",5.1,Classification.кафявиджуджета,1000,"Milky Way1"),
              new Star("Test2",1.5,Classification.субджуджета,250,"Milky Way2"),
              new Star("Test3",9.1,Classification.гиганти,1900,"Milky Way3")
            };
            Console.WriteLine(string.Join("\n",SortedStars(stars)));
        }
        public static List<string> SortedStars(List<Star> list)
        {
            List<string> output = new List<string>();
            foreach (var item in list.OrderBy(x=>x.Distance))
            {
                string text = $"{item.Name}, {item.Distance} св.г., {item.Classification}, {item.Weight} сл.м., {item.Constellation}";
                output.Add(text);
            }
            return output;
        }
    }
}