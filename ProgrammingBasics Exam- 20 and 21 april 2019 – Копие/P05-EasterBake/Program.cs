using System;

public class Program
{
    static void Main()
    {
        int countEasterBread = int.Parse(Console.ReadLine());

        double amountSugar = 0;
        double amountFlour = 0;

        int maxUsedSugar = 0;
        int maxUsedFlour = 0;
        for (int i = 0; i < countEasterBread; i++)
        {
            int usedSugar = int.Parse(Console.ReadLine());
            int usedFlour = int.Parse(Console.ReadLine());

            amountSugar += usedSugar;
            amountFlour += usedFlour;
            if (usedSugar > maxUsedSugar)
            {
                maxUsedSugar = usedSugar;
            }
            if (usedFlour > maxUsedFlour)
            {
                maxUsedFlour = usedFlour;
            }
        }
        double packetsSugar = Math.Ceiling(amountSugar / 950.00);
        double packetsFlour = Math.Ceiling(amountFlour / 750.00);

        Console.WriteLine($"Sugar: {packetsSugar}");
        Console.WriteLine($"Flour: {packetsFlour}");
        Console.WriteLine($"Max used flour is {maxUsedFlour} grams, max used sugar is {maxUsedSugar} grams.");
    }
}

