using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Service.Data.Models
{
    public class Status
    {
        public int Id { get; set; }

        [MaxLength(20)]
        public string Label { get; set; }

        public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    }
}
