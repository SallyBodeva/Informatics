using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Project_EndOfTerm_.Data.Models
{
    [PrimaryKey(nameof(AttendeeId),nameof(EventId))]
    public class AttendeeEvent
    {
        public int AttendeeId { get; set; }

        public virtual Attendee Attendee { get; set; }

        public int EventId { get; set; }

        public virtual Event Event { get; set; }
    }
}
