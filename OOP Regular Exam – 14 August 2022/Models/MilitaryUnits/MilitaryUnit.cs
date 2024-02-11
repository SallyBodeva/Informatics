using PlanetWars.Models.MilitaryUnits.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Models.MilitaryUnits
{
    public abstract class MilitaryUnit : IMilitaryUnit
    {
        public MilitaryUnit(double cost)
        {
            this.Cost = cost;
        }

        public double Cost { get; set; }

        public int EnduranceLevel { get; set; } = 1;

        public void IncreaseEndurance()
        {
            this.EnduranceLevel += 1;
            if (this.EnduranceLevel>20)
            {
                this.EnduranceLevel = 20;
                throw new ArgumentException(Utilities.Messages.ExceptionMessages.EnduranceLevelExceeded);
            }
        }
    }
}
