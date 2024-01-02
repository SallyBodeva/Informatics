using NauticalCatchChallenge.Core.Contracts;
using NauticalCatchChallenge.Models.Contracts;
using P08_NauticalCatchChallenge_OOP_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P08_NauticalCatchChallenge_OOP_.Core
{
    public class Controller : IController
    {
        private DiverRepository divers = new DiverRepository();
        private FishRepository fish = new FishRepository();
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
            List<IDiver> info = divers.Models.OrderByDescending(x => x.CompetitionPoints)
                .ThenByDescending(x => x.Catch.Count).ThenBy(x => x.Name).ToList();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**Nautical-Catch-Challenge**");
            info.ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString().TrimEnd();
        }

        public string DiveIntoCompetition(string diverType, string diverName)
        {
            if (diverType!=nameof(FreeDiver) && diverType!=nameof(ScubaDiver))
            {
                return $"{diverType} is not allowed in our competition.";
            }
            if (divers.GetModel(diverName)!=null)
            {
                return $"{diverName} is already a participant -> {nameof(DiverRepository)}.";
            }
            Diver d = null;
            switch (diverType)
            {
                case nameof(FreeDiver):
                    d = new FreeDiver(diverName);
                    break;
                case nameof(ScubaDiver):
                    d = new ScubaDiver(diverName);
                    break;
                default:
                    throw new ArgumentException("Invalid diver type...");
                    break;
            }
            divers.AddModel(d);
            return $"{diverName} is successfully registered for the competition -> {nameof(DiverRepository)}.";
        }

        public string DiverCatchReport(string diverName)
        {
            IDiver specificDiver = divers.GetModel(diverName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Diver [ Name: {specificDiver.Name}, Oxygen left: {specificDiver.OxygenLevel}, Fish caught: {specificDiver.Catch.Count}, Points earned: {specificDiver.CompetitionPoints}]");
            sb.AppendLine("Catch Report:");
            foreach (var fish in specificDiver.Catch)
            {
                sb.AppendLine(fish.ToString());
            }
            return sb.ToString().TrimEnd();
        }

        public string HealthRecovery()
        {
            List<IDiver> unhealthyDivers = divers.Models.Where(x => x.HasHealthIssues == true).ToList();
            unhealthyDivers.ForEach(x => x.UpdateHealthStatus());
            unhealthyDivers.ForEach(x => x.RenewOxy());
            return $"Divers recovered: {unhealthyDivers.Count}";
        }

        public string SwimIntoCompetition(string fishType, string fishName, double points)
        {
            if (fishType!=nameof(ReefFish) && fishType!= nameof(DeepSeaFish) && fishType!=nameof(PredatoryFish))
            {
                return $"{fishType} is forbidden for chasing in our competition.";
            }
            if (fish.Models.Any(x=>x.Name==fishName))
            {
                return $"{fishName} is already allowed -> {fish.GetType().Name}.";
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
