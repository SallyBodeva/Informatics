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

        public string AddPeak(string name, int elevation, string difficultyLevel)
        {
            if (peaks.Get(name)!=null)
            {
                return $"{name} is already added as a valid mountain destination.";
            }
            if (difficultyLevel!="Extreme" && difficultyLevel!="Hard" && difficultyLevel!="Moderate" )
            {
                return $"{difficultyLevel} peaks are not allowed for international climbers.";
            }
            Peak p = new Peak(name, elevation, difficultyLevel);
            peaks.Add(p);
            return $"{name} is allowed for international climbing. See details in {this.peaks.GetType().Name}.";
        }
        public string NewClimberAtCamp(string name, bool isOxigenUsed)
        {
            if (climbers.Get(name)!=null)
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
            if (climbers.Get(climberName)==null)
            {
               return  $"Climber - {climberName}, has not arrived at the BaseCamp yet.";
            }
            if (peaks.Get(peakName)==null)
            {
                return $"{peakName} is not allowed for international climbing.";
            }
            if (!baseCamp.Residents.Contains(climberName))
            {
                return $"{climberName} not found for gearing and instructions. The attack of {peakName} will be postponed.";
            }
            if (peaks.Get(peakName).DifficultyLevel=="Extreme" && climbers.Get(climberName).Name == "NaturalClimber")
            {
                return $"{climberName} does not cover the requirements for climbing {peakName}.";
            }
            Climber c = climbers.Get(climberName);
            baseCamp.LeaveCamp(climberName);
            if (c.Stamina==0)
            {
                return $"{climberName} did not return to BaseCamp.";
            }
            baseCamp.ArriveAtCamp(climberName);
            return $"{climberName} successfully conquered {peakName} and returned to BaseCamp.";
        }
    }
}

