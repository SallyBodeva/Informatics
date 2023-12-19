using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_HighwayToPeak
{
    public abstract class Climber
    {
        private string name;

        protected Climber(string name, int stamina)
        {
           this.Name = name;
           this.Stamina = stamina;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Climber's name cannot be null or whitespace.");
                }
                name = value;
            }
        }
        public int Stamina  { get; set; }

        public HashSet<string> ConqueredPeaks { get; set; } = new HashSet<string>();

        public void Climb(Peak peak)
        {
            this.ConqueredPeaks.Add(peak.Name);
            switch (peak.DifficultyLevel)
            {
                case "Extreme":
                    this.Stamina -= 6;
                break;
                case "Hard":
                    this.Stamina -= 4;
                    break;
                case "Moderate":
                    this.Stamina -= 2;
                    break;
                default:
                    throw new ArgumentException("Invalid data...");
                    break;
            }
            if (this.Stamina<=0)
            {
                this.Stamina = 0;
            }
            if (this.Stamina>=10)
            {
                this.Stamina = 10;
            }
        }
        public abstract void Rest(int daysCount);
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{GetType().Name} - Name: {Name}, Stamina: {Stamina}");
            if (this.ConqueredPeaks.Any())
            {
                sb.AppendLine($"Peaks conquered: {this.ConqueredPeaks.Count()}");
            }
            else sb.AppendLine($"Peaks conquered: no peaks conquered");
            return sb.ToString().TrimEnd();
        }
    }
}
