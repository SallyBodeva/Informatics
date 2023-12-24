using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_HighwayToPeak
{
    public class PeakRepository
    {
        private readonly List<Peak> all;

        public List<Peak> All => all;
        public void Add(Peak model)
        {
            this.All.Add(model);
        }
        public Peak Get(string name)
        {
            return All.FirstOrDefault(x=>x.Name==name);
        }
    }
}
