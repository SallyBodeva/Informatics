using P14_FishingNet_OOP_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P14_FishingNet_OOP_
{
    public class Net
    {
        private readonly List<Fish> fish;

        public Net(string material, int capacity)
        {
            fish = new List<Fish>();
            this.Material = material;
            this.Capacity = capacity;
        }

        public IReadOnlyCollection<Fish> Fish
        {
            get
            {
                return fish.AsReadOnly();
            }
        }
        public string Material { get; set; }
        public int Capacity { get; set; }
        public int Count => fish.Count;
        public string AddFish(Fish fish)
        {
            if (string.IsNullOrWhiteSpace(fish.FishType) || fish.Length<=0 || fish.Weight<=0)
            {
                return "Invalid fish.";
            }
            if (this.Count+1>this.Capacity)
            {
                return "Fishing net is full.";
            }
            this.fish.Add(fish);
            return $"Successfully added {fish.FishType} to the fishing net.";
        }
        public bool ReleaseFish(double weight)
        {
            Fish f = this.fish.FirstOrDefault(x => x.Weight == weight);
            return this.fish.Remove(f);
        }
        public 	Fish GetFish(string fishType)
        {
            return this.fish.FirstOrDefault(x => x.FishType == fishType);
        }
        public Fish GetBiggestFish()
        {
            return this.fish.OrderByDescending(x => x.Length).First();
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {this.Material}:");
            List<Fish> f = this.fish.OrderByDescending(x => x.Length).ToList();
            f.ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString();
        }
    }
}