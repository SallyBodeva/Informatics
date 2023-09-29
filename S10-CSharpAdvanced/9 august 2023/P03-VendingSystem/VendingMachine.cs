using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingSystem
{
    public class VendingMachine
    {

        private List<Drink> drinks;
        public VendingMachine(int buttonCapacity)
        {
            ButtonCapacity = buttonCapacity;
            drinks = new List<Drink>();
        }

        public int ButtonCapacity { get; set; }

        public int GetCount => this.drinks.Count();

        public void AddDrink(Drink drink)
        {
            if (ButtonCapacity > drinks.Count)
            {
                drinks.Add(drink);
            }
        }

        public bool RemoveDrink(string name)
        {
            return this.drinks.Remove(this.drinks.FirstOrDefault(d => d.Name == name));
        }
        public Drink GetLongest()
        {
            Drink drink = this.drinks.OrderByDescending(d => d.Volume).FirstOrDefault();
            return drink;
        }

        public Drink GetCheapest()
        {
            Drink drink = this.drinks.OrderBy(d => d.Price).FirstOrDefault();
            return drink;
        }

        public string BuyDrink(string name)
        {
            Drink drink = this.drinks.FirstOrDefault(d => d.Name == name);
            return drink.ToString().TrimEnd();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Drinks available:");
            drinks.ForEach(x => sb.AppendLine(x.ToString()));
           
            return sb.ToString().TrimEnd();
        }
    }
}
