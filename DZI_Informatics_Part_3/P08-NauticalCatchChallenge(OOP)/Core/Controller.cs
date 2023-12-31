﻿using NauticalCatchChallenge.Core.Contracts;
using NauticalCatchChallenge.Models.Contracts;
using P08_NauticalCatchChallenge_OOP_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_NauticalCatchChallenge_OOP_.Core
{
    public class Controller : IController
    {
        private DiverRepository divers;
        private FishRepository fish;
        public string ChaseFish(string diverName, string fishName, bool isLucky)
        {
            IDiver d = divers.GetModel(diverName);
            IFish f = fish.GetModel(fishName);
            if (d==null)
            {
                return $"{divers.GetType().Name} has no {diverName} registered for the competition.";
            }
            if (f==null)
            {
                return $"{fishName} is not allowed to be caught in this competition.";
            }
            if (d.HasHealthIssues)
            {
                return $"{diverName} will not be allowed to dive, due to health issues.";
            }
            if (d.OxygenLevel< f.TimeToCatch)
            {
                d.Miss(f.TimeToCatch);
                return $"{diverName} missed a good {fishName}.";
            }
            if (d.OxygenLevel == f.TimeToCatch)
            {
                if (isLucky)
                {
                    d.Hit(f);
                    return $"{diverName} hits a {f.Points}pt. {fishName}.";
                }
                else
                {
                    d.Miss(f.TimeToCatch);
                    return $"{diverName} missed a good {fishName}.";
                }
            }
            d.Hit(f);
            if (d.OxygenLevel==0)
            {
                d.UpdateHealthStatus();
            }
            return $"{diverName} hits a {f.Points}pt. {fishName}.";
        }

        public string CompetitionStatistics()
        {
            throw new NotImplementedException();
        }

        public string DiveIntoCompetition(string diverType, string diverName)
        {
            throw new NotImplementedException();
        }

        public string DiverCatchReport(string diverName)
        {
            throw new NotImplementedException();
        }

        public string HealthRecovery()
        {
            throw new NotImplementedException();
        }

        public string SwimIntoCompetition(string fishType, string fishName, double points)
        {
            if (fishType!=nameof(ReefFish) && fishType!= nameof(DeepSeaFish) && fishType!=nameof(PredatoryFish))
            {
                return $"{fishType} is forbidden for chasing in our competition.";
            }
            if (fish.Models.Any(x=>x.GetType().Name==fishName))
            {
                return $"{fishName} is already allowed -> {divers.GetType().Name}.";
            }
            Fish f = null;
            switch (fishType)
            {
                case nameof(DeepSeaFish):
                    f = new DeepSeaFish(fishName, points);
                    break;
                case nameof(ReefFish):
                    f = new ReefFish(fishName, points);
                    break;
                case nameof(PredatoryFish):
                    f = new PredatoryFish(fishName, points);
                    break;
                default:
                    throw new ArgumentException("Invalid fish type");
                    break;
            }
            fish.AddModel(f);
            return $"{fishName} is allowed for chasing.";
        }
    }
}
