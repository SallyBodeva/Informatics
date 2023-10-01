using System;
using System.Collections.Generic;
using System.Text;

namespace P07_Cars
{
    public class Rally
    {
        private List<Pilot> pilots;
        public Rally(string name, int year)
        {
            this.Name = name;
            this.Year = year;
            pilots = new List<Pilot>();
        }

        public string Name { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rally:{Name} - {Year}");
            pilots.ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString().TrimEnd();
        }
    }
}
