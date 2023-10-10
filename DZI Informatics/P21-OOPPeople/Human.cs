using System;
using System.Collections.Generic;
using System.Text;

namespace P21_OOPPeople
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
            return $"{FirstName} {LastName}, {Age} years old";
        }
    }
}
