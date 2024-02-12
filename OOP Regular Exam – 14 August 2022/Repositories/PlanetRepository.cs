using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetWars.Repositories
{
    public class PlanetRepository : IRepository<IPlanet>
    {
        private readonly List<IPlanet> planets;

        public IReadOnlyCollection<IPlanet> Models
        {
            get
            {
                return planets;
            }
        }

        public void AddItem(IPlanet model)
        {
            this.planets.Add(model);
        }

        public IPlanet FindByName(string name)
        {
            return planets.FirstOrDefault(x => x.Name == name);
        }

        public bool RemoveItem(string name)
        {
            return planets.Remove(FindByName(name));
        }
    }
}
