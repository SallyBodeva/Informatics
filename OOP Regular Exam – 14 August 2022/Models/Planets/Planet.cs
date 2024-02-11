using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetWars.Models.Planets
{
    public class Planet : IPlanet
    {
        private UnitRepository units = new UnitRepository();
        private WeaponRepository weapons = new WeaponRepository();
        private string name;
        private double budget;

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(Utilities.Messages.ExceptionMessages.InvalidPlanetName);
                }
                name = value;
            }
        }

        public double Budget
        {
            get { return budget; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException(Utilities.Messages.ExceptionMessages.InvalidBudgetAmount);
                }
                budget = value;
            }
        }

        public double MilitaryPower { get; set; }

        public IReadOnlyCollection<IMilitaryUnit> Army { get; set; }

        public IReadOnlyCollection<IWeapon> Weapons { get; set; }

        private double MilitaryPowerCalculation()
        {
            double totalSum = weapons.Models.Sum(x => x.DestructionLevel) + units.Models.Sum(x => x.EnduranceLevel);
            if ())
            {

            }
        }

        public void AddUnit(IMilitaryUnit unit)
        {
            throw new NotImplementedException();
        }

        public void AddWeapon(IWeapon weapon)
        {
            throw new NotImplementedException();
        }

        public string PlanetInfo()
        {
            throw new NotImplementedException();
        }

        public void Profit(double amount)
        {
            throw new NotImplementedException();
        }

        public void Spend(double amount)
        {
            throw new NotImplementedException();
        }

        public void TrainArmy()
        {
            throw new NotImplementedException();
        }
    }
}
