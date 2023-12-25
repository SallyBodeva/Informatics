using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Railway.Data.Models
{
    public class Town
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        public virtual ICollection<RailwayStation> RailwayStations { get; set; } = new List<RailwayStation>();

        public virtual ICollection<Train> DepartureTrains { get; set; } = new List<Train>();

        public virtual ICollection<Train> ArrivalTrains { get; set; } = new List<Train>();

    }
}
