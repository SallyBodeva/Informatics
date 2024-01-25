using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Project_EndOfTerm_.Data.Models
{
    public class Ticket
    {
        public int id { get; set; }

        public decimal Price { get; set; }

        public int Attendeeid { get; set; }

        public virtual Attendee Attendee { get; set; }

        public int TicketTypeId { get; set; }

        public virtual TicketType TicketType { get; set; }
    }
}
