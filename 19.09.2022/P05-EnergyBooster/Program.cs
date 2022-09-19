using System;

namespace P05_EnergyBooster
{
    public class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            string friut = Console.ReadLine();
            string size = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            if (size == "small")
            {
                switch (friut)
                {
                    case "Watermelon":
                        sum += 2 * 56;
                        break;
                    case "Mango":
                        sum += 2 * 36.66;
                        break;
                    case "Pineapple":
                        sum += 2 * 42.10;
                        break;
                    case "Raspberry":
                        sum += 2 * 20;
                        break;
                    default:
                        break;
                }
            }
            if (size == "big")
            {
                switch (friut)
                {
                    case "Watermelon":
                        sum += 5 * 28.70;
                        break;
                    case "Mango":
                        sum += 5 * 19.60;
                        break;
                    case "Pineapple":
                        sum += 5 * 24.80;
                        break;
                    case "Raspberry":
                        sum += 5 * 15.20;
                        break;
                    default:
                        break;
                }
            }
                sum = sum * count;
                if (sum >= 400 && sum <= 1000)
                {
                    sum -= sum * 0.15;
                }
                else if (sum > 1000)
                {
                    sum -= sum / 2;
                }
            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
