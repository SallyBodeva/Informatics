using P03_Railway.Data;
using P03_Railway.Data.Models;

namespace P03_Railway
{
    public class Program
    {
        private static AppDbContext context = new AppDbContext();
        public static void Main()
        {

        }

        private static void GetPassengersTickets()
        {
            var result = context.Passengers
                .Select(x =>
                        new
                        {
                            PassengerName = x.Name,
                            TicketPrice = x.Tickets.Select(y => y.Price),
                            DepartuteDate = x.Tickets.Select(y => y.DateOfDeparture),
                            TrainId = x.Tickets.Select(y => y.TrainId)
                        }
                ).OrderByDescending(x => x.TicketPrice).ThenBy(x => x.PassengerName);

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }

        private static void GetTicketsByPriceAndDeparture()
        {
            var result = context.Tickets
               .OrderBy(x => x.Price).ThenByDescending(x => x.DateOfDeparture)
               .Select(x => $"{x.DateOfDeparture} {x.Price}");
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
