using System;
using System.Collections.Generic;
using System.Text;

namespace P21_OOPPeople
{
    public class Student : Human
    {
        public Student(double grade, string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            this.Grade = grade;
        }
        public double Grade { get; private set; }
        public override string ToString()
        {
            return base.ToString() + $", grade: {Grade:f2}";
        }
    }
}
