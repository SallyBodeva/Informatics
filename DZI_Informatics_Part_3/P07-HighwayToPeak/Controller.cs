using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_HighwayToPeak
{
    public class Controller
    {
        private PeakRepository peaks;
        private ClimberRepository climbers;
        private BaseCamp baseCamp;
        public Controller()
        {
            peaks = new PeakRepository();
            climbers = new ClimberRepository();
            baseCamp = new BaseCamp();
        }
        public string AddPeak(string name, int elevation, string difficultyLevel)
        {
            if (peaks.Get(name) != null)
            {
                return $"{name} is already added as a valid mountain destination.";
            }
            if (difficultyLevel != "Extreme" && difficultyLevel != "Hard" && difficultyLevel != "Moderate")
            {
                return $"{difficultyLevel} peaks are not allowed for international climbers.";
            }
            Peak p = new Peak(name, elevation, difficultyLevel);
            peaks.Add(p);
            return $"{name} is allowed for international climbing. See details in {this.peaks.GetType().Name}.";
        }
        public string NewClimberAtCamp(string name, bool isOxigenUsed)
        {
            if (climbers.Get(name) != null)
            {
                return $"{name} is a participant in {peaks.GetType().Name} and cannot be duplicated.";
            }
            Climber c = null;
            if (isOxigenUsed)
            {
                c = new OxygenClimber(name);
            }
            else
            {
                c = new NaturalClimber(name);
            }
            return $"{name} has arrived at the BaseCamp and will wait for the best conditions.";
        }
        public string AttackPeak(string climberName, string peakName)
        {
            if (climbers.Get(climberName) == null)
            {
                return $"Climber - {climberName}, has not arrived at the BaseCamp yet.";
            }
            if (peaks.Get(peakName) == null)
            {
                return $"{peakName} is not allowed for international climbing.";
            }
            if (!baseCamp.Residents.Contains(climberName))
            {
                return $"{climberName} not found for gearing and instructions. The attack of {peakName} will be postponed.";
            }
            if (peaks.Get(peakName).DifficultyLevel == "Extreme" && climbers.Get(climberName).Name == "NaturalClimber")
            {
                return $"{climberName} does not cover the requirements for climbing {peakName}.";
            }
            Climber c = climbers.Get(climberName);
            baseCamp.LeaveCamp(climberName);
            c.Climb(peaks.Get(peakName));
            if (c.Stamina == 0)
            {
                return $"{climberName} did not return to BaseCamp.";
            }
            baseCamp.ArriveAtCamp(climberName);
            return $"{climberName} successfully conquered {peakName} and returned to BaseCamp.";
        }
        public string CampRecovery(string climberName, int daysToRecover)
        {
            if (!baseCamp.Residents.Contains(climberName))
            {
                return $"{climberName} not found at the BaseCamp.";
            }
            if (climbers.Get(climberName).Stamina == 10)
            {
                return $"{climberName} has no need of recovery.";
            }
            Climber c = climbers.Get(climberName);
            c.Rest(daysToRecover);
            return $"{climberName} has been recovering for {daysToRecover} days and is ready to attack the mountain.";
        }
        public string BaseCampReport()
        {
            StringBuilder sb = new StringBuilder();
            if (baseCamp.Residents.Count == 0)
            {
                sb.AppendLine("BaseCamp is currently empty.");
            }
            else
            {
                sb.AppendLine("BaseCamp residents:");
                foreach (var climberName in baseCamp.Residents)
                {
                    Climber c = climbers.Get(climberName);
                    sb.AppendLine($"Name: {c.Name}, Stamina: {c.Stamina}, Count of Conquered Peaks: {c.ConqueredPeaks.Count}");
                }
            }
            return sb.ToString().TrimEnd();
        }
        public string OverallStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***Highway-To-Peak***");
            foreach (var climber in climbers.All)
            {
                sb.AppendLine($"{climber.Name}");
                Climber c = climbers.Get(climber.Name);
                foreach (var peak in c.ConqueredPeaks)
                {
                    sb.AppendLine($"{peak}");
                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}

