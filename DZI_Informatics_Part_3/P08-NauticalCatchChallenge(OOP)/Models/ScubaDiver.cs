using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_NauticalCatchChallenge_OOP_.Models
{
    public class ScubaDiver : Diver
    {
        public ScubaDiver(string name) : base(name, 540)
        {
        }

        public override void Miss(int TimeToCatch)
        {
            int usedOxy = (int)Math.Round(540 * 0.3);
            base.OxygenLevel -= usedOxy;
        }

        public override void RenewOxy()
        {
            base.OxygenLevel = 540;
        }
    }
}
