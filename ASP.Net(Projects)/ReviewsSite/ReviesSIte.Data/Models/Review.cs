using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviesSIte.Data.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public int Rating { get; set; }
        public string OwnerId { get; set; }
        public virtual Owner Owner { get; set; }
    }
}
