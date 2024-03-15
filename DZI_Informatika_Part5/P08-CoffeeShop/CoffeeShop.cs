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

        public CoffeeShop()
        {
            coffees = new List<Coffee>();
        }

        public string Name { get; set; }
        public void AddCoffee(string name, double price)
        {
            Coffee coffee = new Coffee(name, price);
            this.coffees.Add(coffee);
        }

        public double AveragePriceInRange(double start, double end)
        {
            List<Coffee> cfs = coffees.Where(x => x.Price > start && x.Price < end).ToList();
            return cfs.Average(x => x.Price);
        }


        public List<string> FilterCoffeesByPrice(double price)
        {
            return coffees.Where(x => x.Price < price).Select(x => x.Type).ToList();
        }

        public List<Coffee> SortAscendingByType()
        {
            return this.coffees.OrderBy(x => x.Type).ToList();
        }

        public List<Coffee> SortDescendingByPrice()
        {
            return this.coffees.OrderByDescending(x => x.Price).ToList();
        }

        public bool CheckCoffeeIsInCoffeeShop(string name)
        {
            return this.coffees.Any(x => x.Type == name);
        }

        public string[] ProvideInformationAboutAllCoffees()
        {
            return coffees.Select(x => x.ToString()).ToArray();
        }


    }
}
