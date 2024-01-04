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

        private static void GetMaintenanceInspectionWithTown()
        {
            var result = context.MaintenanceRecords
                  .Where(x => x.Details.Contains("inspection")).ToList();

            foreach (var item in result.OrderBy(x => x.TrainId))
            {
                Console.WriteLine($"{item.TrainId} {item.Train.DepartureTown.Name} {item.Details}");
            }
        }

        private static void TrainsDeparturingAt8()
        {
            var result = context.Tickets
                .Where(x => (x.Price > 50) && (x.Train.HourOfDepartute.Substring(0, 2) == "08"))
                .Select(x => new
                {
                    TrainId = x.Train.Id,
                    Hour = x.Train.HourOfDepartute,
                    Price = x.Price,
                    Town = x.Train.ArrivalTown.Name
                }).OrderBy(x => x.Price).ThenBy(x => x.TrainId);

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }

        private static void GetRailwayStationsWithoutPassingTrains()
        {
            var notScheduledTrains = context.TrainRailwayStations.Select(x => x.RailwayStationId);

            var result = context.RailwayStations.Where(x => notScheduledTrains.All(t => x.Id != t))
                .Select(x =>
                    new
                    {
                        town = x.Town.Name,
                        RailwayStationName = x.Name
                    }
                ).OrderBy(x => x.town).ThenBy(x => x.RailwayStationName);

            Console.WriteLine(string.Join(Environment.NewLine, result));
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

