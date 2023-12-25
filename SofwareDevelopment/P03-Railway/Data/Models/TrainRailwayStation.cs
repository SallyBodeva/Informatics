using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Railway.Data.Models
{
    [PrimaryKey(nameof(TrainId),nameof(RailwayStatioId))]
    public class TrainRailwayStation
    {
        public int TrainId { get; set; }

        public Train Train { get; set; }

        public int RailwayStatioId { get; set; }

        public RailwayStation RailwayStation { get; set; }
    }
}
