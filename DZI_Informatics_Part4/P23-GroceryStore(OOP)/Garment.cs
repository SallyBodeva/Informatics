using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P23_GroceryStore_OOP_
{
    public class Garment:Product,IComparable<Garment>
    {
        public Type Type { get; set; }
        public string Size { get; set; }
        public string Material { get; set; }

        public int CompareTo(Garment? other)
        {
            throw new NotImplementedException();
        }
    }
}
