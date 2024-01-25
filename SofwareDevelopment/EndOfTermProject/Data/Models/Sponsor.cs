using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Project_EndOfTerm_.Data.Models
{
    public class Sponsor
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        public virtual ICollection<Event> Events { get; set; } = new List<Event>();
    }
}
