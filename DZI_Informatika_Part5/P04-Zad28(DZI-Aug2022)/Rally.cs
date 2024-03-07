using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Zad28_DZI_Aug2022_
{
    public class Rally
    {
        private List<Pilot> piltots;

        public Rally(string name, int year)
        {
            Name = name;
            Year = year;
            piltots = new List<Pilot>();
        }

        public string Name { get; private set; }
        public int Year { get; private set; }
        public void AddPilot(Pilot pilot)
        {
            this.piltots.Add(pilot);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rally: {this.Name} - {this.Year}");
            this.piltots.ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString().TrimEnd();
        }
    }
}
