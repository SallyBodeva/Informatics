using InfluencerManagerApp.Models;
using InfluencerManagerApp.Models.Contracts;
using InfluencerManagerApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Repositories
{
    public class InfluencerRepository : IRepository<IInfluencer>
    {
        private List<IInfluencer> models = new List<IInfluencer>();
        public IReadOnlyCollection<IInfluencer> Models
        {
            get
            {
                return models.AsReadOnly();
            }
        }

        public void AddModel(IInfluencer model)
        {
            this.models.Add(model);
        }

        public IInfluencer FindByName(string name)
        {
            return this.models.FirstOrDefault(x => x.Username == name);
        }

        public bool RemoveModel(IInfluencer model)
        {
            return this.models.Remove(model);
        }
    }
}
