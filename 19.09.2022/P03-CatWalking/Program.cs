using System;

namespace P03_CatWalking
{
    public class Program
    {
        static void Main(string[] args)
        {
            int minutesWalking = int.Parse(Console.ReadLine());
            int countWalking = int.Parse(Console.ReadLine());
            int callories = int.Parse(Console.ReadLine());

            int minutes = minutesWalking * countWalking;
            int burntCaolliries = minutes * 5;
            if (burntCaolliries>=callories/2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burntCaolliries}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burntCaolliries}.");
            }
        }
    }
}
