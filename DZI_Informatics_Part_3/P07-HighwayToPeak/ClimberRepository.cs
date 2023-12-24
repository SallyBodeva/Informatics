using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_HighwayToPeak
{
    public class ClimberRepository
    {
        public List<Climber> All { get; set; }

        public void Add(Climber model)
        {
            this.All.Add(model);
        }
        public Climber Get(string name)
        {
            return this.All.FirstOrDefault(x => x.Name == name);
        }
    }
}
