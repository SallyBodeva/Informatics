using Microsoft.EntityFrameworkCore;
using P03_Railway.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Railway.Data
{
    public class AppDbContext:DbContext
    {
        private const string ConnectionString = "Server=DESKTOP-0FTTVGR; Database=RailwayEf2; Trusted_Connection=True; TrustServerCertificate=True";

        public virtual DbSet<MaintenanceRecord> MaintenanceRecords { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<RailwayStation> RailwayStations { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Town> Towns { get; set; }
        public virtual DbSet<Train> Trains { get; set; }
        public virtual DbSet<TrainRailwayStation> TrainRailwayStations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Train>
               (
                       option =>
                       {
                           option
                       .HasOne(h => h.DepartureTown)
                       .WithMany(p => p.DepartureTrains)
                       .HasForeignKey(x => x.DepartureTownId)
                       .OnDelete(DeleteBehavior.NoAction);

                           option
                   .HasOne(p => p.ArrivalTown)
                   .WithMany(p => p.ArrivalTrains)
                   .HasForeignKey(x => x.ArrivalTownId)
                   .OnDelete(DeleteBehavior.NoAction);
                       }

               );
        }
    }
}
