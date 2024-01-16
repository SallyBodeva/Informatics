namespace P17_OnlineStore
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Client> clients = new List<Client>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int[] date = Console.ReadLine().Split('.').Select(int.Parse).ToArray();
                int day = date[0];
                int month = date[1];
                int year = date[2];
                int itemsCount = int.Parse(Console.ReadLine());
                double bill = double.Parse(Console.ReadLine());
                string stars = string.Empty;
                if (itemsCount >= 1 && itemsCount <= 99) stars = "*";
                else if (itemsCount >= 100 && itemsCount <= 299) stars = "**";
                else if (itemsCount >= 300 && itemsCount <= 499) stars = "***";
                else if (itemsCount >= 500 && itemsCount <= 999) stars = "****";
                else if (itemsCount >= 1000 && itemsCount <= 9999) stars = "*****";

                DateTime registrationDate = new DateTime(year, month, day);
                Client c = new Client(name, registrationDate, itemsCount, bill);

            }
            YearClients(clients);
        }

        private static void YearClients(List<Client> clients)
        {
            int rating = int.Parse(Console.ReadLine());
            List<Client> clientsWithRating = clients.Where(x => x.Rating.Length == rating).ToList();
            int distingYearCount = clientsWithRating.Select(x => x.RegistrationDate.Year).Count();
            for (int i = 0; i < distingYearCount; i++)
            {
                List<int> distingYear = clientsWithRating.Select(x => x.RegistrationDate.Year).ToList();
                Console.WriteLine($"{distingYear[i]} {clients.Where(x => x.RegistrationDate.Year == distingYear[1]).Count()}");
            }
        }

        private static void ClientsWithRating2(List<Client> clients)
        {
            List<Client> clientsWithRating2 = clients.Where(x => x.Rating == "**").ToList();
            foreach (var c in clientsWithRating2.OrderByDescending(x => x.Bill).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{c.Name}, {c.ItemsCount}, {c.Bill:f2}, {c.RegistrationDate.ToString("dd.MM.yyyy")}, {c.Rating}");
            }
        }

        private static void ClientsInfo1(List<Client> clients)
        {
            foreach (var c in clients.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{c.Name}, {c.ItemsCount}, {c.Bill:f2}, {c.RegistrationDate.ToString("dd.MM.yyyy")}, {c.Rating}");
            }
        }
    }
}
