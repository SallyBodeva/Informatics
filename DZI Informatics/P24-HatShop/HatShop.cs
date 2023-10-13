using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace P24_HatShop
{
    public class HatShop
    {
        private readonly List<Hat> hats;
        private string name;

        public HatShop(string name)
        {
            this.Name = name;
            hats = new List<Hat>();
        }

        public string Name
        {
            get => name; set
            {
                if (value.Length<6)
                {
                    throw new ArgumentException("Invalid hat shop name!");
                }
                name = value;
            }
        }
        public void AddHat(Hat hat)
        {
            hats.Add(hat);
        }

        public bool SellHat(Hat Hat)
        {
            return hats.Remove(Hat);
        }

        public double CalculateTotalPrice()
        {
            return this.hats.Sum(x => x.Price);
        }

        public Hat GetHatWithHighestPrice()
        {
            return hats.OrderByDescending(x => x.Price).FirstOrDefault();
        }

        public Hat GetHatWithLowestPrice()
        {
            return hats.OrderBy(x => x.Price).FirstOrDefault();
        }

        public void RenameHatShop(string newName)
        {
            this.Name = newName;
        }

        public void SellAllHats()
        {
            hats.Clear();
        }
        public Hat GetHat(string type, string color, double price)
        {
            return hats.FirstOrDefault(x => x.Type == type && x.Color == color && x.Price == price);
        }
        public override string ToString()
        {
            if (hats.Count != 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Hat shop {this.Name} has {hats.Count} hat/s:");
                hats.ForEach(x => sb.AppendLine(x.ToString()));
                return sb.ToString().TrimEnd();
            }
            return $"Hat shop {this.Name} has no available hats.";
        }

    }
}
