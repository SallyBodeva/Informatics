using System;
using System.Collections.Generic;
using System.Text;

namespace P07_Cars
{
    public class Pilot
    {
        public Pilot(string name, int age, Car carp, string category)
        {
            this.Name = name;
            this.Age = age;
            this.Carp = carp;
            this.Category = category;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public Car Carp { get; set; }

        public string Category { get; set; }
        public override string ToString()
        {
            return $"{Name},{Age},{Category},{Carp},";
        }
    }
}
