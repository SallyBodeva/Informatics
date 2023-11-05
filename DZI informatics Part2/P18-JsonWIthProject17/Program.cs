using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace P14_FishingNet_OOP_
{
    public class Program
    {
        static void Main()
        {
            Fish fishOne = new Fish("salmon", 44.25, 941.15);
            Fish fishTwo = new Fish("catfish", 105.25, 2100.15);
            Fish fishThree = new Fish("bass", 25.25, 321.15);

            Fish fishFour = new Fish("mullet", 15.21, 150.33);
            Fish fishFive = new Fish("barbel", 21.33, 190.14);
            Fish fishSix = new Fish("trout", 38.35, 357.41);
            List<Fish> fish = new List<Fish>() { fishOne, fishTwo, fishThree, fishFour, fishFive, fishSix };

            string jsonSerialised = string.Empty;
            foreach (var item in fish)
            {
                jsonSerialised+= $"\n{JsonSerializer.Serialize(item)}";
            }
            Console.WriteLine(jsonSerialised);

            StreamWriter writer = new StreamWriter("C:\\Users\\EliteBook\\Desktop\\Output.txt");
            using (writer)
            {
                writer.Write(jsonSerialised);
            }
        }
    }
}
