using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P24_zad_26_DZI_26._8_22_
{
    public class Student : Human
    {
        public Student(string firstName, string lastName, int age, double grade) : base(firstName, lastName, age)
        {
            this.Grade = grade;
        }
        public double Grade { get; private set; }

        public override string ToString()
        {
            return base.ToString()+ $", grade: {Grade}"; 
        }
    }
}
