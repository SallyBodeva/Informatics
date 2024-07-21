using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Repositories
{
    public class DelicacyRepository : IRepository<IDelicacy>
    {
        private List<IDelicacy> delicacy = new List<IDelicacy>();
        public IReadOnlyCollection<IDelicacy> Models
        {
            get
            {
                return this.delicacy.AsReadOnly();
            }
        }

        public void AddModel(IDelicacy model)
        {
            this.delicacy.Add(model);
        }
    }
}
