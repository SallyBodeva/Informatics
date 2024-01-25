using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Project_EndOfTerm_.Data.Models
{
    public class TicketType
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string TicketName { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
