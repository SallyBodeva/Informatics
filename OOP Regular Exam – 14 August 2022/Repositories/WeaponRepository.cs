using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetWars.Repositories
{
    public class WeaponRepository : IRepository<IWeapon>
    {
        private readonly List<IWeapon> weapons = new List<IWeapon>();
        public IReadOnlyCollection<IWeapon> Models
        {
            get
            {
                return weapons;
            }
        }

        public void AddItem(IWeapon model)
        {
            this.weapons.Add(model);
        }

        public IWeapon FindByName(string name)
        {
            return weapons.FirstOrDefault(x => x.GetType().Name == name);
        }

        public bool RemoveItem(string name)
        {
            IWeapon weapon = FindByName(name);
            return weapons.Remove(weapon);
        }
    }
}
