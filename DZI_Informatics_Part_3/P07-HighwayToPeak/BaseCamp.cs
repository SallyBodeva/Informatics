using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_HighwayToPeak
{
    public class BaseCamp
    {
        public List<string> Residents { get; set; }
        public BaseCamp()
        {
            this.Residents = new List<string>();
        }

        public void ArriveAtCamp(string climberName)
        {
            this.Residents.Add(climberName);
        }
        public void LeaveCamp(string climberName)
        {
            this.Residents.Remove(climberName);
        }
        
    }
}
