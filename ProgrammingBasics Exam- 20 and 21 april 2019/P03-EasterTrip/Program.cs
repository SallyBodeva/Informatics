using System;

public class Program
{
    static void Main()
    {
        string country = Console.ReadLine();
        string date = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());
        double sum = 0;
        if (country=="France")
        {
            switch (date)
            {
                case "21-23":
                    sum += nights * 30;
                    break;
                case "24-27":
                    sum += nights * 35;
                    break;
                case "28-31":
                    sum += nights * 40;
                    break;
                
            }
        }
        else if (country == "Italy")
        {
            switch (date)
            {
                case "21-23":
                    sum += nights * 28;
                    break;
                case "24-27":
                    sum += nights * 32;
                    break;
                case "28-31":
                    sum += nights * 39;
                    break;
                default:
                    break;
            }
        }
        else if (country == "Germany")
        {
            switch (date)
            {
                case "21-23":
                    sum += nights * 32;
                    break;
                case "24-27":
                    sum += nights * 37;
                    break;
                case "28-31":
                    sum += nights * 43;
                    break;
             
            }
        }
        Console.WriteLine($"Easter trip to {country} : {sum:f2} leva.");
    }
}

