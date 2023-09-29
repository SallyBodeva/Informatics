using System;

namespace P01_Marketing
{
    public class Program
    {
        static void Main()
        {
            double adsSocialMedia = double.Parse(Console.ReadLine());
            double adsBillBoard = adsSocialMedia * 2;
            double localMedia = adsBillBoard * 0.85;
            double adsSum = localMedia + adsBillBoard;
            double adsMaterials = adsSum / 7;
            double totalSum = adsSocialMedia+adsSum + adsMaterials;
            Console.WriteLine(Math.Round(totalSum,2));
        }
    }
}
