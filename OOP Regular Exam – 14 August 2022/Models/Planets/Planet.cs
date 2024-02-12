using PlanetWars.Models.MilitaryUnits;
using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Models.Weapons;
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
        private readonly double militaryPower;
        private readonly IReadOnlyCollection<IMilitaryUnit> army;

        public Planet(string name, double budget)
        {
            this.Name = name;
            this.Budget = budget;
        }

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

        public double MilitaryPower
        {
            get
            {
                return this.MilitaryPowerCalculation() ;
            }
        }

        public IReadOnlyCollection<IMilitaryUnit> Army
        {
            get
            {
                return units.Models;
            }
        }

        public IReadOnlyCollection<IWeapon> Weapons
        {
            get
            {
                return weapons.Models;
            }
        }

        private double MilitaryPowerCalculation()
        {
            double totalSum = weapons.Models.Sum(x => x.DestructionLevel) + units.Models.Sum(x => x.EnduranceLevel);
            IMilitaryUnit unit = this.units.FindByName(nameof(AnonymousImpactUnit));
            if (unit!=null)
            {
                totalSum += 1.3 * totalSum;
            }
            IWeapon weapon = this.weapons.FindByName(nameof(NuclearWeapon));
            if (weapon!=null)
            {
                totalSum += 1.45 * totalSum;
            }
            return Math.Round(totalSum, 3);
        }

        public void AddUnit(IMilitaryUnit unit)
        {
            this.units.AddItem(unit);
        }

        public void AddWeapon(IWeapon weapon)
        {
            this.weapons.AddItem(weapon);
        }

        public string PlanetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Planet: {this.Name}");
            sb.AppendLine($"--Budget: {this.budget} billion QUID");
            string forces = (this.units.Models.Any()) ? string.Join(" ", units.Models) : "No forces";
            sb.AppendLine($"--Forces: {forces}");
            string euipment = (this.weapons.Models.Any()) ? string.Join(" ", weapons.Models) : "No weapons";
            sb.AppendLine($"--Combat equipment: {euipment}");
            return sb.ToString().TrimEnd();
        }

        public void Profit(double amount)
        {
            this.budget += amount;
        }

        public void Spend(double amount)
        {
            if (this.budget<amount)
            {
                throw new ArgumentException(Utilities.Messages.ExceptionMessages.UnsufficientBudget);
            }
            this.budget -= amount;
        }

        public void TrainArmy()
        {
            foreach (var item in this.Army)
            {
                item.IncreaseEndurance();
            }
        }
    }
}
