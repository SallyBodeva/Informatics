using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Text;

namespace P03_ClothingMagazine
{
    public class Magazine
    {
        private List<Cloth> clothes;

        public Magazine(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
            clothes = new List<Cloth>();
        }

        public string Type { get; set; }
        public int Capacity { get; set; }
        public void AddCloth(Cloth cloth)
        {
            if (this.Capacity > clothes.Count)
            {
                this.clothes.Add(cloth);
            }
        }
        public bool RemoveCloth(string color)
        {
            Cloth c = this.clothes.FirstOrDefault(x => x.Color == color);
            return this.clothes.Remove(c);
        }
        public Cloth GetSmallestCloth()
        {
            return this.clothes.OrderBy(x => x.Size).First();
        }
        public Cloth GetCloth(string color)
        {
            return this.clothes.FirstOrDefault(x => x.Color == color);
        }
        public int GetClothCount()
        {
            return this.clothes.Count;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Type} magazine contains:");
            clothes = clothes.OrderBy(x => x.Size).ToList();
            clothes.ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString().TrimEnd();
        }
    }
}
