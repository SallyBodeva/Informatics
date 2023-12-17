using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Service.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string UserName { get; set; }

        [MaxLength(50)]
        public string Password { get; set; }

        [MaxLength(50)]
        public string? Name { get; set; }

        public DateTime? Birthdate { get; set; }

        public int Age { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    }
}
