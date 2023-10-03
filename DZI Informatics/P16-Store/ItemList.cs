using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P16_Store
{
    public class ItemList:IEnumerable<Item>
    {
        private List<Item> items;
        private int size;

        public ItemList()
        {
            items = new List<Item>().OrderBy(x => x.Price).ToList();
        }
        public int Size
        {
            get
            {
                return this.items.Count;
            }
        }
        public Item Get(int index)
        {
            try
            {
                return this.items[index];
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Add(Item i)
        {
            this.items.Add(i);
            items.OrderBy(x => x.Price);
        }

        public IEnumerator<Item> GetEnumerator()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
