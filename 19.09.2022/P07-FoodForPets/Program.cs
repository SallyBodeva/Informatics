using System;

namespace P07_FoodForPets
{
    public class Program
    {
        static void Main(string[] args)
        {
            double eatenQuantity = 0;
            double biscuit = 0;
            double dogEating = 0;
            double catEating = 0;

            int days = int.Parse(Console.ReadLine());
            double foodQuantity = double.Parse(Console.ReadLine());

            for (int i = 1; i <= days; i++)
            {
                double dailyDog = int.Parse(Console.ReadLine());
                double dailyCat = int.Parse(Console.ReadLine());
                dogEating += dailyDog;
                catEating += dailyCat;
                if (i==3)
                {
                    biscuit += (dailyCat + dailyDog) * 0.1;
                }
            }

            eatenQuantity += dogEating + catEating;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuit)}gr.");
            Console.WriteLine($"{eatenQuantity*100/foodQuantity:f2}% of the food has been eaten.");
            Console.WriteLine($"{(dogEating*100)/eatenQuantity:f2}% eaten from the dog.");
            Console.WriteLine($"{(catEating * 100) / eatenQuantity:f2}% eaten from the cat.");
        }
    }
}
