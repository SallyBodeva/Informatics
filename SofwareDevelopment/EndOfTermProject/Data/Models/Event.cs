﻿using EndOfTermProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Project_EndOfTerm_.Data.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int AddressId { get; set; }

        public virtual Address Address { get; set; }

        public int SponsorId { get; set; }

        public virtual Sponsor Sponsor { get; set; }

        public DateTime DateOfTakingPlace { get; set; }

        public decimal Budget { get; set; }

        public virtual ICollection<AttendeeEvent> AttendeeEvents { get; set; } = new List<AttendeeEvent>();
        public virtual ICollection<EmployeeEvent> EmployeeEvents { get; set; } = new List<EmployeeEvent>();
    }
}
