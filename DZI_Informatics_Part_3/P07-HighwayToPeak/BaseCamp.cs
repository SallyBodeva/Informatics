using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_HighwayToPeak
{
    public class BaseCamp
    {
        private List<string> residents;
        public BaseCamp()
        {
            this.residents = new List<string>();
        }

        public void ArriveAtCamp(string climberName)
        {
            this.residents.Add(climberName);
        }
        public void LeaveCamp(string climberName)
        {
            this.residents.Remove(climberName);
        }
    }
}
