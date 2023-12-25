using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Railway.Data.Models
{
    public class Train
    {
        public int Id { get; set; }

        [MaxLength(5)]
        public string HourOfDepartute { get; set; }

        [MaxLength(5)]
        public string HourOfArrival { get; set; }

        public int DepartureTownId { get; set; }

        public virtual Town DepartureTown { get; set; }

        public int ArrivalTownId { get; set; }
        public virtual Town ArrivalTown { get; set; }

        public virtual ICollection<TrainRailwayStation> TrainsRailwayStations { get; set; } = new List<TrainRailwayStation>();

        public virtual ICollection<MaintenanceRecord> MaintenanceRecords { get; set; } = new List<MaintenanceRecord>();

        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    }
}
