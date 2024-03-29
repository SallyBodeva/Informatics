﻿using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_NauticalCatchChallenge_OOP_.Models
{
    public class FishRepository : IRepository<IFish>
    {
        private List<IFish> fish = new List<IFish>();
        public IReadOnlyCollection<IFish> Models => fish;

        public void AddModel(IFish model)
        {
            fish.Add(model);
        }

        public IFish GetModel(string name)
        {
            if (fish.Any(x=>x.Name==name))
            {
                return this.fish.FirstOrDefault(x => x.Name == name); 
            }
            return null;
        }
    }
}
