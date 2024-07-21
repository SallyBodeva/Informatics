using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Repositories
{
    public class CocktailRepository : IRepository<ICocktail>
    {
        private List<ICocktail> cocktails = new List<ICocktail>();
        public IReadOnlyCollection<ICocktail> Models
        {
            get
            {
                return cocktails.AsReadOnly();
            }
        }

        public void AddModel(ICocktail model)
        {
            this.cocktails.Add(model);
        }
    }
}
