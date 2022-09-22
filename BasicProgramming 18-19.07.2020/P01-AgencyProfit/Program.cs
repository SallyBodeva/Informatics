using System;

public class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int countAdultTickets = int.Parse(Console.ReadLine());
        int countKidsTickets = int.Parse(Console.ReadLine());
        double AdultTicketPrice =double.Parse(Console.ReadLine());
        double assistancePrice =double.Parse(Console.ReadLine());

        double sum = 0;

        double priceKidsTicket = AdultTicketPrice - 0.7 * AdultTicketPrice;
        double adultProfit = countAdultTickets * (AdultTicketPrice + assistancePrice);
        double kidsProfit = countKidsTickets *( priceKidsTicket + assistancePrice);
        sum += adultProfit + kidsProfit;
        double totalProfit = 0.2 * sum;
        Console.WriteLine($"The profit of your agency from {name} tickets is {totalProfit:f2} lv.");
    }
}

