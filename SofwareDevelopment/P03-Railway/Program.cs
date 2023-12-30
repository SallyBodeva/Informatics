﻿using P03_Railway.Data;
using P03_Railway.Data.Models;

namespace P03_Railway
{
    public class Program
    {
        private static AppDbContext context = new AppDbContext();
        public static void Main()
        {

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