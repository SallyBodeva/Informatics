﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P03_Railway.Data;

#nullable disable

namespace P03_Railway.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("P03_Railway.Data.Models.MaintenanceRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("DateOfMaintenance")
                        .HasColumnType("date");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<int>("TrainId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrainId");

                    b.ToTable("MaintenanceRecords");
                });

            modelBuilder.Entity("P03_Railway.Data.Models.Passenger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("P03_Railway.Data.Models.RailwayStation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TownId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TownId");

                    b.ToTable("RailwayStations");
                });

            modelBuilder.Entity("P03_Railway.Data.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("DateOfArrival")
                        .HasColumnType("date");

                    b.Property<DateOnly>("DateOfDeparture")
                        .HasColumnType("date");

                    b.Property<int>("PassengerId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TrainId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PassengerId");

                    b.HasIndex("TrainId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("P03_Railway.Data.Models.Town", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Towns");
                });

            modelBuilder.Entity("P03_Railway.Data.Models.Train", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArrivalTownId")
                        .HasColumnType("int");

                    b.Property<int>("DepartureTownId")
                        .HasColumnType("int");

                    b.Property<string>("HourOfArrival")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("HourOfDepartute")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("Id");

                    b.HasIndex("ArrivalTownId");

                    b.HasIndex("DepartureTownId");

                    b.ToTable("Trains");
                });

            modelBuilder.Entity("P03_Railway.Data.Models.TrainRailwayStation", b =>
                {
                    b.Property<int>("TrainId")
                        .HasColumnType("int");

                    b.Property<int>("RailwayStationId")
                        .HasColumnType("int");

                    b.HasKey("TrainId", "RailwayStationId");

                    b.HasIndex("RailwayStationId");

                    b.ToTable("TrainRailwayStations");
                });

            modelBuilder.Entity("P03_Railway.Data.Models.MaintenanceRecord", b =>
                {
                    b.HasOne("P03_Railway.Data.Models.Train", "Train")
                        .WithMany("MaintenanceRecords")
                        .HasForeignKey("TrainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Train");
                });

            modelBuilder.Entity("P03_Railway.Data.Models.RailwayStation", b =>
                {
                    b.HasOne("P03_Railway.Data.Models.Town", "Town")
                        .WithMany("RailwayStations")
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Town");
                });

            modelBuilder.Entity("P03_Railway.Data.Models.Ticket", b =>
                {
                    b.HasOne("P03_Railway.Data.Models.Passenger", "Passenger")
                        .WithMany("Tickets")
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P03_Railway.Data.Models.Train", "Train")
                        .WithMany("Tickets")
                        .HasForeignKey("TrainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Passenger");

                    b.Navigation("Train");
                });

            modelBuilder.Entity("P03_Railway.Data.Models.Train", b =>
                {
                    b.HasOne("P03_Railway.Data.Models.Town", "ArrivalTown")
                        .WithMany("ArrivalTrains")
                        .HasForeignKey("ArrivalTownId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("P03_Railway.Data.Models.Town", "DepartureTown")
                        .WithMany("DepartureTrains")
                        .HasForeignKey("DepartureTownId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ArrivalTown");

                    b.Navigation("DepartureTown");
                });

            modelBuilder.Entity("P03_Railway.Data.Models.TrainRailwayStation", b =>
                {
                    b.HasOne("P03_Railway.Data.Models.RailwayStation", "RailwayStation")
                        .WithMany("TrainsRailwayStations")
                        .HasForeignKey("RailwayStationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P03_Railway.Data.Models.Train", "Train")
                        .WithMany("TrainsRailwayStations")
                        .HasForeignKey("TrainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RailwayStation");

                    b.Navigation("Train");
                });

            modelBuilder.Entity("P03_Railway.Data.Models.Passenger", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("P03_Railway.Data.Models.RailwayStation", b =>
                {
                    b.Navigation("TrainsRailwayStations");
                });

            modelBuilder.Entity("P03_Railway.Data.Models.Town", b =>
                {
                    b.Navigation("ArrivalTrains");

                    b.Navigation("DepartureTrains");

                    b.Navigation("RailwayStations");
                });

            modelBuilder.Entity("P03_Railway.Data.Models.Train", b =>
                {
                    b.Navigation("MaintenanceRecords");

                    b.Navigation("Tickets");

                    b.Navigation("TrainsRailwayStations");
                });
#pragma warning restore 612, 618
        }
    }
}
