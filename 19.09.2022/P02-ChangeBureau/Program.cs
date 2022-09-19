using System;

namespace P02_ChangeBureau
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int bitcoin = int.Parse(Console.ReadLine());
            double chinaMoney = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            int bitcoinLv = bitcoin * 1168;
            double joanLv = chinaMoney * 0.15 * 1.76;
            double moneyEvro = (bitcoinLv+joanLv)/1.95;
            double total = moneyEvro - (moneyEvro * (commision / 100));

            Console.WriteLine($"{total:f2}");
        }
    }
}
