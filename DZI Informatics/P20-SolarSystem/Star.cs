using System;
using System.Collections.Generic;
using System.Text;

namespace P20_SolarSystem
{
    public class Star
    {
        private string name;
        private double distance;

        public Star(string name, double distance, int classification, double weight, string constellation)
        {
            this.Name = name;
            this.Distance = distance;
            this.Classification = classification;
            this.Weight = weight;
            this.Constellation = constellation;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (value.Length > 20)
                {
                    throw new ArgumentException("Invalid name...");
                }
                name = value;
            }
        }
        public double Distance
        {
            get => distance; private set
            {
                if (value<0)
                {
                    throw new ArgumentException("Invalid distance...");
                }
                distance = value;
            }
        }
        public int Classification { get; set; }
        public double Weight { get; set; }
        public string Constellation { get; set; }
    }
}
