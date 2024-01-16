using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_ItemClass
{
    public class ItemList
    {
        private readonly int count;
        private List<Item> items;

        public int Count
        {
            get
            {
                return this.items.Count;
            }
        }
        public Item Get(int index)
        {
            if (index<0 || index>=items.Count)
            {
                throw new ArgumentException("Invalid index...");
            }
            return items[index];
        }
        public void Add(Item i)
        {
            this.items.Add(i);
            this.items.OrderBy(x => x.Description).ThenBy(x => x.Price);
        }
    }
}
