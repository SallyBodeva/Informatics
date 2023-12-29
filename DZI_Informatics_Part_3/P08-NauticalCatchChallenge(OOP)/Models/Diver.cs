using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_NauticalCatchChallenge_OOP_.Models
{
    public abstract class Diver : IDiver
    {
        private string name;
        private int oxygenLevel;
        private List<string> @catch;
        private double competitionPoints = 0;
        private bool hasHealthIssues;

        protected Diver(string name, int oxygenLevel)
        {
            this.Name = name;
            this.OxygenLevel = oxygenLevel;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.DiversNameNull));
                }
                name = value;
            }
        }

        public int OxygenLevel
        {
            get
            {
                return oxygenLevel;
            }
            set
            {
                oxygenLevel = value;
            }
        }

        public IReadOnlyCollection<string> Catch
        {
            get
            {
                return @catch;
            }
        }

        public double CompetitionPoints
        {
            get
            {
                return competitionPoints;
            }
        }

        public bool HasHealthIssues
        {
            get
            {
                return hasHealthIssues;
            }
        }

        public void Hit(IFish fish)
        {
            this.OxygenLevel -= fish.TimeToCatch;
            @catch.Add(fish.Name);
            this.competitionPoints += fish.Points;
        }

        public abstract void RenewOxy();

        public void UpdateHealthStatus()
        {
            if (hasHealthIssues) hasHealthIssues = false;
            else hasHealthIssues = true;
        }

        public abstract void Miss(int TimeToCatch);
        public override string ToString()
        {
            return $"Diver [ Name: {Name}, Oxygen left: {OxygenLevel}, Fish caught: {Catch.Count}, Points earned: {CompetitionPoints} ]";
        }
    }
}
