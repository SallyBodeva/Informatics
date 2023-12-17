using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Service.Data.Models
{
    public class Report
    {
        public int Id { get; set; }

        public int CategoryId  { get; set; }

        public virtual Category Category { get; set; }

        public int StatusId { get; set; }

        public virtual Status Status { get; set; }

        public DateTime OpenDate { get; set; }

        public DateTime? CloseDate { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int? EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

    }
}
