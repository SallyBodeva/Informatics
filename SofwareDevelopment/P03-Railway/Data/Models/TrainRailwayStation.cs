﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Railway.Data.Models
{
    [PrimaryKey(nameof(TrainId),nameof(RailwayStationId))]
    public class TrainRailwayStation
    {
        public int TrainId { get; set; }

        public virtual Train Train { get; set; }

        public int RailwayStationId { get; set; }

        public virtual RailwayStation RailwayStation { get; set; }
    }
}
