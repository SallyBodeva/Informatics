using System;
using System.Collections.Generic;
using System.Linq;

namespace P29_E_clients
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Client> clients = new List<Client>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string[] data = Console.ReadLine().Split('.');
                int day = int.Parse(data[0]);
                int month = int.Parse(data[1]);
                int year = int.Parse(data[2]);
                DateTime registrationDate = new DateTime(year,month,day);
                int itemsCount = int.Parse(Console.ReadLine());
                double sum = double.Parse(Console.ReadLine());
                string rating = string.Empty;
                if (itemsCount > 1 && itemsCount <= 99) rating = "*";
                else if (itemsCount >= 100 && itemsCount <= 299) rating = "**";
                else if (itemsCount >= 300 && itemsCount <= 499) rating = "***";
                else if (itemsCount >= 500 && itemsCount <= 999) rating = "****";
                else if (itemsCount >= 1000 && itemsCount <= 9999) rating = "*****";
                Client c = new Client() { Name = name, RegistationDate = registrationDate, BoughtItemsCount = itemsCount, Bill = sum, Rating = rating };
                clients.Add(c);
            }
            foreach (var item in clients.OrderBy(x=>x.Name))
            {
                Console.WriteLine($"{item.Name}, {item.BoughtItemsCount}, {item.Bill:f2}, {item.RegistationDate}");
            }
            List<Client> clinetsRating2 = clients.Where(x => x.Rating == "**").ToList();
            foreach (var item in clinetsRating2.OrderByDescending(x=>x.Bill).ThenBy(x=>x.Name))
            {
                Console.WriteLine($"{item.Name}, {item.BoughtItemsCount}, {item.Bill:f2}, {item.RegistationDate}");
            }

        }
    }
}
