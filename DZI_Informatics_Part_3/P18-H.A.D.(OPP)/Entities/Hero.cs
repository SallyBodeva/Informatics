using HAD.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18_H.A.D._OPP_.Entities
{
    public class Hero : IHero
    {
        private string name;
        private long strength;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }

        public long Strength
        {
            get
            {
                return strength;
            }
            set
            {
                strength = value;
            }
        }

        public long Agility => throw new NotImplementedException();

        public long Intelligence => throw new NotImplementedException();

        public long HitPoints => throw new NotImplementedException();

        public long Damage => throw new NotImplementedException();

        public IReadOnlyCollection<IItem> Items => throw new NotImplementedException();

        public void AddItem(IItem item)
        {
            throw new NotImplementedException();
        }

        public void AddRecipe(IRecipe recipe)
        {
            throw new NotImplementedException();
        }
    }
}
