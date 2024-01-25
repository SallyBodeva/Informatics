using Microsoft.EntityFrameworkCore;
using P04_Project_EndOfTerm_.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndOfTermProject.Data.Models
{
    [PrimaryKey(nameof(EmployeeId), nameof(EventId))]
    public class EmployeeEvent
    {
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

        public int EventId { get; set; }

        public virtual Event Event { get; set; }
    }
}
