using System;
using System.Collections.Generic;
using System.Text;

namespace P29_E_clients
{
    public class Client
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length>40)
                {
                    throw new ArgumentException("Name cannot have more that 40 symbols.");
                }
                name = value;
            }
        }
        public DateTime RegistationDate { get; set; }

        public int BoughtItemsCount { get; set; }

        public double Bill { get; set; }

        public string Rating { get; set; }
    }
}
