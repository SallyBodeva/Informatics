using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Zad28_DZI_Aug2022_
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

        public string Name { get; private set; }
        public int Age { get; private set; }
        public Car Carp { get; private set; }
        public string Category { get; private set; }

        public override string ToString()
        {
            return $"{this.Name}, {this.Age}, {this.Category}, {this.Carp.Brand}, {this.Carp.HPower}";
        }
    }
}
