using System;


public class Program
{
    static void Main()
    {
        double sum = 0;
        double priceBagAbove20 = double.Parse(Console.ReadLine());
        double bagsWeight= double.Parse(Console.ReadLine());
        int daysUntilFlight = int.Parse(Console.ReadLine());
        int bagsCount = int.Parse(Console.ReadLine());

        if (bagsWeight <10)
        {
            sum += 0.2 * priceBagAbove20;

        }
        if (bagsWeight>=10 && bagsWeight<=20)
        {
            sum += 0.5 * priceBagAbove20;
        }
        else if (bagsWeight>20)
        {
            sum += priceBagAbove20;
        }
        if (daysUntilFlight>30)
        {
            sum += sum * 0.1;
        }
        if (daysUntilFlight >=7 && daysUntilFlight<=30)
        {
            sum += sum * 0.15;
        }
        if (daysUntilFlight <7)
        {
            sum += sum * 0.40;
        }
        sum *= bagsCount;
        Console.WriteLine($" The total price of bags is: {sum:f2} lv. ");
    }
}

