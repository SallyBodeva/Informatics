using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace P08_NauticalCatchChallenge_OOP_.Models
{
    public class DiverRepository:IRepository<IDiver>
    {

        private List<IDiver> divers = new List<IDiver>();
        public IReadOnlyCollection<IDiver> Models => divers;

        public void AddModel(IDiver diver)
        {
            divers.Add(diver);
        }

        public IDiver GetModel(string name)
        {
            if (divers.Any(x=>x.Name==name))
            {
                return this.divers.FirstOrDefault(x => x.Name == name);
            }
            return null;
        }
    }
}
