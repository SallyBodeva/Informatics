using System;

public class Program
{
    static void Main()
    {
        int countEasterBread = int.Parse(Console.ReadLine());
        int countBoxesEggs = int.Parse(Console.ReadLine());
        int cookiesKg = int.Parse(Console.ReadLine());

        double sum_easterBread = countEasterBread * 3.20;
        double sum_cookies =cookiesKg*5.40;
        double sum_eggs = countBoxesEggs * 4.35;
        double sum_Paint = countBoxesEggs * 12 * 0.15;
        double sumTotal = sum_cookies + sum_easterBread + sum_eggs + sum_Paint;
        Console.WriteLine($"{sumTotal:f2}");
    }
}

