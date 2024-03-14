using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_CoffeeShop
{
    public class Coffee
    {
        public Coffee(string type, double price)
        {
            this.Type = type;
            this.Price = price;
        }

        public string Type { get; private set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"Coffee {this.Type} costs {this.Price:f2} lv.";
        }
    }
}
