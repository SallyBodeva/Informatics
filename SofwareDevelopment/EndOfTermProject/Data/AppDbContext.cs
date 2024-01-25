using EndOfTermProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using P04_Project_EndOfTerm_.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndOfTermProject.Data
{
    public class AppDbContext:DbContext
    {
        private const string ConnectionString = "Server=DESKTOP-0FTTVGR; Database=EventManagementEf2; Trusted_Connection=True; TrustServerCertificate=True";

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Attendee> Attendees { get; set; }
        public virtual DbSet<AttendeeEvent> AttendeeEvents { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeEvent> EmployeeEvents { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Sponsor> Sponsors { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<TicketType> TicketTypes { get; set; }
        public virtual DbSet<Town> Towns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
            optionsBuilder.UseLazyLoadingProxies();
        }

    }
}
