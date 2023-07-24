using System;
using System.Collections.Generic;
using System.Text;

namespace P03_UniversityCompetition
{
    public abstract class Subject
    {
        private int id;
        private string name;
        private double rate;

        protected Subject(int id, string name, double rate)
        {
            this.Id = id;
            this.Name = name;
            this.Rate = rate;
        }

        public int Id
        {
            get => id;
            private set
            {
                id = value;
            }
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }
                name = value;
            }
        }
        public double Rate
        {
            get { return rate; }
            private set
            {
                rate = value;
            }
        }
    }
}
