using System;
using System.Collections.Generic;
using System.Text;

namespace P21_OOPPeople
{
    public class Worker : Human
    {
        public Worker(double wage, int workHours, string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            this.Wage = wage;
            this.WorkHours = workHours;
        }
        public double Wage { get; private set; }
        public int WorkHours { get; private set; }
        public double Salary()
        {
            return this.Wage * WorkHours;
        }
        public override string ToString()
        {
            return base.ToString() + $", salary: ${Salary():f2}";
        }
    }
}
