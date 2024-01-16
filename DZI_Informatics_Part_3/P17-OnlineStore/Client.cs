using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17_OnlineStore
{
    public class Client
    {
        public Client(string name, DateTime registrationDate, int itemsCount, double bill)
        {
            this.Name = name;
            this.RegistrationDate = registrationDate;
            this.ItemsCount = itemsCount;
            this.Bill = bill;
        }

        public string Name { get; set; }

        public DateTime RegistrationDate { get; set; }

        public int ItemsCount { get; set; }

        public double Bill { get; set; }

        public string Rating { get; set; }
    }
}
