using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_SharkTaxonomy
{
    public class Classifier
    {
        private readonly List<Shark> species = new List<Shark>();
        private readonly int getCount;

        public Classifier(int capacity)
        {
            this.Capacity = capacity;
        }

        public int Capacity { get; set; }
        public int GetCount => this.species.Count;
        public List<Shark> Species
        {
            get
            {
                return species;
            }
        }
        public void AddShark(Shark shark)
        {
            if (this.Capacity>=this.GetCount+1 && !this.species.Any(x=>x.Kind==shark.Kind))
            {
                this.species.Add(shark);
            }
        }
        public bool RemoveShark(string kind)
        {
            return this.species.Remove(species.FirstOrDefault(x => x.Kind == kind));
        }

        public string GetLargestShark()
        {
            return this.species.OrderByDescending(x => x.Length).FirstOrDefault().ToString();
        }
        public double GetAverageLength()
        {
            return this.species.Average(x => x.Length);
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetCount} sharks classified:");
            species.ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString().TrimEnd();
        }
    }
}
