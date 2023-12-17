using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Service.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [MaxLength(25)]
        public string? FirstName { get; set; }

        [MaxLength(25)]
        public string? LastName { get; set; }

        public DateTime? Birthdate { get; set; }

        public int? Age { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    }
}
