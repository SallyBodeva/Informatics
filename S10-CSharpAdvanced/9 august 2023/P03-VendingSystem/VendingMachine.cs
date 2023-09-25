using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace P03_VendingSystem
{
    public class VendingMachine
    {
        private readonly int getCount;
        private List<Drink> drinks;

        public VendingMachine(int buttonCapacity)
        {
            this.ButtonCapacity = buttonCapacity;
            drinks = new List<Drink>();
        }
        public int ButtonCapacity { get; set; }
        public int GetCount
        {
            get
            {
                return drinks.Count;
            }
        }
        public void AddDrink(Drink drink)
        {
            if (ButtonCapacity > GetCount)
            {
                drinks.Add(drink);
            }
        }
        public bool RemoveDrink(string name)
        {
            Drink dr = drinks.FirstOrDefault(x => x.Name == name);
            if (dr != null)
            {
                drinks.Remove(dr);
                return true;
            }
            return false;
        }
        public Drink GetLongest()
        {
            Drink d = drinks.OrderBy(x => x.Volume).LastOrDefault();
            return d;
        }
        public Drink GetCheapest()
        {
            return drinks.OrderBy(x => x.Price).FirstOrDefault();
        }
        public string BuyDrink(string name)
        {
            return drinks.FirstOrDefault(x => x.Name == name).ToString();
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Drinks available:");
            drinks.ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString();
        }
    }
}