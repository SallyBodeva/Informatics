using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_NauticalCatchChallenge_OOP_.Models
{
    public class DeepSeaFish : Fish
    {
        public DeepSeaFish(string name, double points) : base(name, points, 180)
        {
        }
    }
}
