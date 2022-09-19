using System;

namespace P09_CareOfPuppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantityKg = int.Parse(Console.ReadLine());
            int foidQuantityGrams = foodQuantityKg * 1000;
            int foodEaten = 0;
            
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd=="Adopted")
                {
                    break;
                }
                foodEaten += int.Parse(cmd); 
            }
            if (foodEaten<=foidQuantityGrams)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foidQuantityGrams-foodEaten} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {foodEaten-foidQuantityGrams} grams more.");
            }
        }
    }
}
