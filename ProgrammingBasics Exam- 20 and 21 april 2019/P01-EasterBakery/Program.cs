using System;

public class Program
{
    static void Main()
    {
        double sum = 0;
        double flourKgPrice = double.Parse(Console.ReadLine());
        double flourKg = double.Parse(Console.ReadLine());
        double sugarKg = double.Parse(Console.ReadLine());
        int boxesEggs = int.Parse(Console.ReadLine());
        int packsYeast = int.Parse(Console.ReadLine());

        double sugarKgPrice = flourKgPrice * 0.75;
        double boxEggsPrice = 1.1 * flourKgPrice;
        double packYeastPrice = 0.2 * sugarKgPrice;

        double sumSugar = sugarKgPrice * sugarKg;
        double sumFlour = flourKgPrice * flourKg;
        double sumEggs = boxEggsPrice * boxesEggs;
        double sumYeast = packYeastPrice * packsYeast;
        sum += sumSugar + sumFlour + sumEggs + sumYeast;
        Console.WriteLine($"{sum:f2}");
    }
}

