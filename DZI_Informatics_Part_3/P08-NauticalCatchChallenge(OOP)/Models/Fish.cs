using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_NauticalCatchChallenge_OOP_.Models
{
    public class Fish : IFish
    {
        private string name;
        private double points;
        private int timeToCatch;

        public Fish(string name, double points, int timeToCatch)
        {
            this.Name = name;
            this.Points = points;
            this.TimeToCatch = timeToCatch;
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.FishNameNull));
                }
                name = value;
            }
        }

        public double Points
        {
            get
            {
                return points;
            }
            set
            {
                if (value<1 || value>10)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.PointsNotInRange));
                }
                points = value;
            }
        }

        public int TimeToCatch
        {
            get
            {
                return timeToCatch;
            }
            set
            {
                timeToCatch = value;
            }
        }
        public override string ToString()
        {
            return $"{GetType().Name}: {Name} [ Points: {Points}, Time to Catch: {TimeToCatch} seconds ]";
        }
    }
}
