using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P24_zad_26_DZI_26._8_22_
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, int age, double wage, int workingHours) : base(firstName, lastName, age)
        {
            this.Wage = wage;
            this.WorkingHours = workingHours;
        }
        public double Wage { get; private set; }
        public int WorkingHours { get; private set; }
        public override string ToString()
        {
            return base.ToString()+$", salary: {(this.Wage*this.WorkingHours):f2}";
        }
    }
}
