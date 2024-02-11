using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetWars.Repositories
{
    public class UnitRepository : IRepository<IMilitaryUnit>
    {
        private readonly List<IMilitaryUnit> units = new List<IMilitaryUnit>();
        public IReadOnlyCollection<IMilitaryUnit> Models
        {
            get
            {
                return units;
            }
        }

        public void AddItem(IMilitaryUnit model)
        {
            units.Add(model);
        }

        public IMilitaryUnit FindByName(string name)
        {
            return units.FirstOrDefault(x => x.GetType().Name == name);
        }

        public bool RemoveItem(string name)
        {
            IMilitaryUnit unit = FindByName(name);
            return units.Remove(unit);
        }
    }
}
