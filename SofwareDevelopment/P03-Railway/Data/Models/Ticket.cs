using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Railway.Data.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public DateOnly DateOfDeparture { get; set; }

        public DateOnly DateOfArrival { get; set; }

        public int TrainId { get; set; }

        public virtual Train Train { get; set; }

        public int PassengerId { get; set; }

        public virtual Passenger Passenger { get; set; }

    }
}
