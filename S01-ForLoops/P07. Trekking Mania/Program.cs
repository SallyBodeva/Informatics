using System;


public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int musalaClimbers = 0;
        int monblanClimbers = 0;
        int kilimanjaroClimbers = 0;
        int k2Climbers = 0;
        int everestClimbers = 0;
        double Climbers = 0;
        for (int i = 1; i <= n; i++)
        {
            int people = int.Parse(Console.ReadLine());
            if (people<=5)
            {
                musalaClimbers += people;
            }
            else if (people>=6 && people<=12)
            {
                monblanClimbers += people;
            }
            else if (people>=13 && people<=25)
            {
                kilimanjaroClimbers += people;
            }
            else if (people>=26 && people<=40)
            {
                k2Climbers += people;
            }
            else if (people>=41)
            {
                everestClimbers += people;
            }
            Climbers += people;
        }
        double musalaP = musalaClimbers / Climbers * 100.00;
        double monblanP = monblanClimbers / Climbers * 100.00;
        double kilimanjaroP = kilimanjaroClimbers / Climbers * 100.00; 
        double k2P= k2Climbers / Climbers * 100.00;
        double everestP = everestClimbers / Climbers * 100.00;
        Console.WriteLine($"{musalaP:f2}%");
        Console.WriteLine($"{monblanP:f2}%");
        Console.WriteLine($"{kilimanjaroP:f2}%");
        Console.WriteLine($"{k2P:f2}%");
        Console.WriteLine($"{everestP:f2}%");
    }
}

