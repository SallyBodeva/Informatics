using System;

namespace P08_TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double people = 0;
            double peopleMusala = 0;
            double peopleMonblan = 0;
            double peopleKilimanjaro = 0;
            double peopleK2 = 0;
            double peopleEverest = 0; 

            int countGroups = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countGroups; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());
                if (peopleInGroup>=0&&peopleInGroup<=5)
                {
                    peopleMusala += peopleInGroup;
                }
                if (peopleInGroup>=6&&peopleInGroup<=12)
                {
                    peopleMonblan += peopleInGroup;
                }
                if (peopleInGroup >= 13 && peopleInGroup <= 25)
                {
                    peopleKilimanjaro += peopleInGroup;
                }
                if (peopleInGroup >= 26 && peopleInGroup <= 40)
                {
                    peopleK2 += peopleInGroup;
                }
                if (peopleInGroup >= 41)
                {
                    peopleEverest += peopleInGroup;
                }
                people += peopleInGroup;

            }
            Console.WriteLine($"{peopleMusala * 100 / people:f2}%"); ;
            Console.WriteLine($"{peopleMonblan * 100 / people:f2}%");
            Console.WriteLine($"{peopleKilimanjaro * 100 / people:f2}%");
            Console.WriteLine($"{peopleK2 * 100 / people:f2}%");
            Console.WriteLine($"{peopleEverest * 100 / people:f2}%");
        }
    }
}
