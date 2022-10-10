using System;


public class Program
{
    static void Main()
    {
        double profit = 0;
        string size = Console.ReadLine();
        string color = Console.ReadLine();
        int partidi = int.Parse(Console.ReadLine());
        if (size=="Large")
        {
            switch (color)
            {
                case "Red":
                    profit = partidi * 16;
                    break;
                case "Green":
                    profit = partidi * 12;
                    break;
                case "Yellow":
                    profit = partidi * 9;
                    break;
            }
        }
        else if (size == "Medium")
        {
            switch (color)
            {
                case "Red":
                    profit = partidi * 13;
                    break;
                case "Green":
                    profit = partidi * 9;
                    break;
                case "Yellow":
                    profit = partidi * 7;
                    break;
            }
        }
        else if (size == "Small")
        {
            switch (color)
            {
                case "Red":
                    profit = partidi * 9;
                    break;
                case "Green":
                    profit = partidi * 8;
                    break;
                case "Yellow":
                    profit = partidi * 5;
                    break;
            }
        }
        profit *= 0.65;
        Console.WriteLine($"{profit:f2} leva.");
    }
}

