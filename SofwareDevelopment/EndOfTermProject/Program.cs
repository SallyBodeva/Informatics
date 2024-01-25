using EndOfTermProject.Data;
using EndOfTermProject.Data.Models;
using EndOfTermProject.Service;
using P04_Project_EndOfTerm_.Data.Models;

namespace EndOfTermProject
{
    internal class Program
    {
        private static AppDbContext context = new AppDbContext();
        static void Main(string[] args)
        {
            //InsertTowns();
            //InsertAddresses();
            //InsertAttendees();
            //InsertSponsors();
            //InsertEmployees();
            //InsertTicketTypes();
            //InsertTickets();
            //InsertEvents();
            //InsertAttendeeEventAndEmployeeEvent();

            Console.WriteLine(AppService.GetAttendeTicket());
        }
        public static void InsertTowns()
        {
            List<string> towns = new List<string> { "London", "Paris", "Sofia", "Plovdiv", "Burgas" };
            for (int i = 0; i < towns.Count; i++)
            {
                context.Towns.Add(new Town() { Name = towns[i] });
            }
            context.SaveChanges();
        }
        public static void InsertAddresses()
        {
            List<(string Name, int TownId)> addresses = new List<(string, int)>
            {
                ("Potter str №7", 1),
                ("Vitosha bul", 3),
                ("Petko Voivoda", 4),
                ("Kraibrezna", 5)
            };

            foreach (var (Name, TownId) in addresses)
            {
                context.Addresses.Add(new Address() { Name = Name, TownId = TownId });
            }

            context.SaveChanges();
        }
        public static void InsertAttendees()
        {
            List<(string FirstName, string LastName, int Age, string Email)> attendees = new List<(string, string, int, string)>
            {
                 ("Mitko", "Kovachev", 45, "mitkp@abv.bg"),
                 ("Elena", "Petrova", 2, "eli@abv.bg"),
                 ("John", "Potter", 35, "John@abv.bg"),
                 ("Kaya", "McDaisy", 19, "kayap@abv.bg")
            };

            foreach (var (FirstName, LastName, Age, Email) in attendees)
            {
                context.Attendees.Add(new Attendee() { FirstName = FirstName, LastName = LastName, Age = Age, Email = Email });
            }

            context.SaveChanges();
        }
        public static void InsertSponsors()
        {
            List<(string Name, string PhoneNum, string Email)> sponsors = new List<(string, string, string)>
              {
                  ("LG", "02938823", "lg@gmai.com"),
                  ("Pepsi", "034323", "pepsi@gmai.com"),
                  ("Billa", "03443423", "billa@gmai.com"),
                  ("XIXO", "029343", "xixo@gmai.com")
              };

            foreach (var (Name, PhoneNum, Email) in sponsors)
            {
                context.Sponsors.Add(new Sponsor() { Name = Name, PhoneNumber = PhoneNum, Email = Email });
            }

            context.SaveChanges();
        }
        public static void InsertEmployees()
        {
            List<(string FirstName, string LastName, int Age, string Email, string Position, string PhoneNumber)> employees = new List<(string, string, int, string, string, string)>
            {
                ("John", "Harrison", 29, "john@gmail.com", "Manager", "0929389330"),
                ("Milla", "Roberts", 35, "milla@gmail.com", "PR agent", "023289330"),
                ("Anna", "Smith", 40, "anna@gmail.com", "Assistant", "02323330"),
                ("Will", "Nowels", 19, "eva@gmail.com", "Security", "0829389330")
            };

            foreach (var (FirstName, LastName, Age, Email, Position, PhoneNumber) in employees)
            {
                context.Employees.Add(new Employee()
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    Age = Age,
                    Email = Email,
                    Position = Position,
                    PhoneNumber = PhoneNumber
                });
            }

            context.SaveChanges();
        }
        public static void InsertTicketTypes()
        {
            List<string> ticketTypes = new List<string>
            {
                "VIP",
                "Standard",
                "Platinum",
                "Kid <7"
            };

            foreach (var typeName in ticketTypes)
            {
                context.TicketTypes.Add(new TicketType() { TicketName = typeName });
            }

            context.SaveChanges();
        }
        public static void InsertTickets()
        {
            List<(decimal Price, int AttendeeId, int TicketTypeId)> tickets = new List<(decimal, int, int)>
            {
                (18.99m, 1, 2),
                (99.99m, 2, 1),
                (150m, 3, 3),
                (18.99m, 3, 4)
            };

            foreach (var (Price, AttendeeId, TicketTypeId) in tickets)
            {
                context.Tickets.Add(new Ticket()
                {
                    Price = Price,
                    Attendeeid = AttendeeId,
                    TicketTypeId = TicketTypeId
                });
            }

            context.SaveChanges();
        }
        public static void InsertEvents()
        {
            List<(string Name, int AddressId, int SponsorId, DateTime DateOfTakingPlace, decimal Budget)> events = new List<(string, int, int, DateTime, decimal)>
            {
                ("The Voice Tour", 1, 2, new DateTime(2024, 12, 22), 10000),
                ("Game Contest", 2, 1, new DateTime(2024, 9, 10), 1000),
                ("Basketball tournament", 3, 4, new DateTime(2025, 1, 1), 60000),
                ("New Year Eve Concert", 1, 1, new DateTime(2023, 12, 31), 5000)
            };

            foreach (var (Name, AddressId, SponsorId, DateOfTakingPlace, Budget) in events)
            {
                context.Events.Add(new Event()
                {
                    Name= Name,
                    AddressId = AddressId,
                    SponsorId = SponsorId,
                    DateOfTakingPlace = DateOfTakingPlace,
                    Budget = Budget
                });
            }

            context.SaveChanges();
        }
        public static void InsertAttendeeEventAndEmployeeEvent()
        {
            List<(int AttendeeId, int EventId)> attendeeEventRelations = new List<(int, int)>
            {
                (1, 1),
                (1, 2),
                (2, 3),
                (3, 4)
            };

            List<(int EmployeeId, int EventId)> employeeEventRelations = new List<(int, int)>
            {
                (1, 1),
                (1, 2),
                (2, 3),
                (3, 4)
            };

            foreach (var (AttendeeId, EventId) in attendeeEventRelations)
            {
                context.AttendeeEvents.Add(new AttendeeEvent()
                {
                    AttendeeId = AttendeeId,
                    EventId = EventId
                });
            }

            foreach (var (EmployeeId, EventId) in employeeEventRelations)
            {
                context.EmployeeEvents.Add(new EmployeeEvent()
                {
                    EmployeeId = EmployeeId,
                    EventId = EventId
                });
            }

            context.SaveChanges();
        }


    }
}
