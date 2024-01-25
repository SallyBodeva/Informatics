using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Project_EndOfTerm_.Data.Models
{
    public class Attendee
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public int Age { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

        public virtual ICollection<AttendeeEvent> AttendeeEvents { get; set; } = new List<AttendeeEvent>();

    }
}
