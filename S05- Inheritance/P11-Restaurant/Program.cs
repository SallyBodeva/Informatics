using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main()
    {
        List<Food> food = new List<Food>();
        List<Beverag> beverage = new List<Beverag>();
        double callories = 0;
        bool containsCake = false;
        while (true)
        {
            string[] data = Console.ReadLine().Split(' ');
            if (data[0] == "End")
            {
                break;
            }
            switch (data[0])
            {
                case "Coffe":
                    Beverag b1 = new Coffee(data[1], double.Parse(data[2]));
                    beverage.Add(b1);
                    break;
                case "Tea":
                    Beverag b2 = new Tea(data[1], decimal.Parse(data[2]), double.Parse(data[3]));
                    beverage.Add(b2);
                    break;
                case "Fish":
                    Fish f = new Fish(data[1], decimal.Parse(data[2]));
                    food.Add(f);
                    break;
                case "Soup":
                    Soup s = new Soup(data[1], decimal.Parse(data[2]), double.Parse(data[3]));
                    food.Add(s);
                    break;
                case "Cake":
                   Cake c  = new Cake(data[1]);
                    callories += c.Calories;
                    containsCake = true;
                    break;
            }

        }
        double bM = beverage.Sum(x => x.Millilliters);
        double fG = food.Sum(x => x.Grams);
        if (containsCake)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Your order contains:");
            sb.AppendLine($"\tQuantity of liquids: {bM}");
            sb.AppendLine($"\tGrams of food {fG}");
            sb.AppendLine($"\tCalories {callories}");
            sb.AppendLine($"\tFinal amount {bM + fG}");
        }
        else
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Your order contains:");
            sb.AppendLine($"\tQuantity of liquids: {bM}");
            sb.AppendLine($"\tGrams of food {fG}");
            sb.AppendLine($"\tFinal amount {bM + fG}");
        }
    }
}

