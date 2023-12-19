using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_HighwayToPeak
{
    public class OxygenClimber : Climber
    {
        public OxygenClimber(string name) : base(name, 10)
        {
        }

        public override void Rest(int daysCount)
        {
            this.Stamina += daysCount * 1;
        }
    }
}
