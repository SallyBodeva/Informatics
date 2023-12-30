using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_NauticalCatchChallenge_OOP_.Models
{
    public class FreeDiver : Diver
    {
        public FreeDiver(string name) : base(name, 120)
        {
        }

        public override void Miss(int TimeToCatch)
        {
            int usedOxy = (int)Math.Round(120 * 0.6);
            base.OxygenLevel -= usedOxy;
        }

        public override void RenewOxy()
        {
            base.OxygenLevel = 120;
        }
    }
}
