using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Railway.Data.Models
{
    public class MaintenanceRecord
    {
        public int Id { get; set; }

        public DateOnly DateOfMaintenance { get; set; }

        [MaxLength(2000)]
        public string Details { get; set; }

        public int TrainId { get; set; }

        public virtual Train Train { get; set; }
    }
}
