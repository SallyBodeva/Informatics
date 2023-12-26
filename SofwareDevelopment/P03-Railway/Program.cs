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
            var result = context.Tickets
                .Select(x =>
                        new
                        {
                            PassengerName = x.Passenger.Name,
                            TicketPrice = x.Price,
                            DepartuteDate = x.DateOfDeparture,
                            TrainId = x.TrainId
                        }
                ).OrderByDescending(x => x.TicketPrice).ThenBy(x => x.PassengerName);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
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
