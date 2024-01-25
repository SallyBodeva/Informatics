using EndOfTermProject.Data;
using EndOfTermProject.Data.Models;
using Microsoft.Extensions.Logging;
using P04_Project_EndOfTerm_.Data.Models;
using System.Text;

namespace EndOfTermProject.Service
{
    public static class AppService
    {
        private static AppDbContext context = new AppDbContext();

        public static string GetAttendessOver35()
        {
            List<AttendeeEvent> attendees = context.AttendeeEvents.Where(x => x.Attendee.Age > 35).OrderBy(x => x.AttendeeId).ToList();
            StringBuilder sb = new StringBuilder();
            foreach (var item in attendees)
            {
                sb.AppendLine($"Name-{item.Attendee.FirstName} {item.Attendee.LastName}, Age: {item.Attendee.Age} ({item.Attendee.Email})" +
                    $"{Environment.NewLine}will attend the {item.Event.Name}");
            }
            return sb.ToString().TrimEnd();
        }
        public static string GetEmployeeAndEvent()
        {
            List<EmployeeEvent> employees = context.EmployeeEvents.OrderBy(x=>x.Event.Sponsor.Name).ToList();
            StringBuilder sb = new StringBuilder();
            foreach (var item in employees)
            {
                sb.AppendLine($"{item.Employee.FirstName} {item.Employee.LastName} will work at " +
                    $"{item.Event.Name} and the sponsor of the event will be {item.Event.Sponsor.Name}");
            }
            return sb.ToString().TrimEnd();
        }
        public static string GetAttendeTicket()
        {
            List<Ticket> tickets = context.Tickets.OrderBy(x => x.Price).ToList();
            StringBuilder sb = new StringBuilder();
            foreach (var item in tickets)
            {
                sb.AppendLine($"{item.Attendee.FirstName} {item.Attendee.LastName} bougth a ticket" +
                    $" that is type {item.TicketType.TicketName} and it costs {item.Price}");
            }
            return sb.ToString().TrimEnd();
        }
        public static string GetEventWithBudgetUnder15000()
        {
            List<Event> events = context.Events.Where(x => x.Name.Length < 15 && x.Budget < 15000).OrderBy(x=>x.Id).ToList();
            StringBuilder sb = new StringBuilder();
            foreach (var item in events)
            {
                sb.AppendLine($"Event: {item.Name} with budget of {item.Budget}$");
            }
            return sb.ToString().TrimEnd();
        }
        public static string GetEmployeesAtPosition()
        {
            List<Employee> employees = context.Employees.Where(x => x.Position == "PR agent" || x.Position == "Security")
                .OrderBy(x => x.Age).ToList();
            StringBuilder sb = new StringBuilder();
            foreach (var item in employees)
            {
                sb.AppendLine($"{item.FirstName} {item.LastName} works as {item.Position}");
            }
            return sb.ToString().TrimEnd();
        }
        public static string GetTicketInfo()
        {
            List<Ticket> tickets = context.Tickets.ToList();
            StringBuilder sb = new StringBuilder();
            foreach (var item in tickets)
            {
                sb.AppendLine($"Ticket that is type: {item.TicketType.TicketName} costs {item.Price}$");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
