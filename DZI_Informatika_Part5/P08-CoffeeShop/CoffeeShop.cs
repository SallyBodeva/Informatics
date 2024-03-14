using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_CoffeeShop
{
    public class CoffeeShop
    {
        private List<Coffee> coffees;

        public CoffeeShop(string name)
        {
            this.Name = name;
            coffees = new List<Coffee>();
        }

        public string Name { get; set; }

    }
}
