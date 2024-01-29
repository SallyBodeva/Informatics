using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P24_zad_26_DZI_26._8_22_
{
    public class Human
    {
        public Human(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public int Age { get; private set; }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}, {this.Age} years old";
        }
    }
}
