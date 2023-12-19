using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_HighwayToPeak
{
    public class Peak
    {
        private string name;
        private int elevation;

        public Peak(string name, int elevation, string difficultyLevel)
        {
            this.Name = name;
            this.Elevation = elevation;
            this.DifficultyLevel = difficultyLevel;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Peak name cannot be null or whitespace.");
                }
                name = value;
            }
        }
        public int Elevation
        {
            get { return elevation; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Peak elevation must be a positive value.");
                }
                elevation = value;
            }
        }
        public string DifficultyLevel  { get; set; }
        public override string ToString()
        {
            return $"Peak: {Name} -> Elevation: {Elevation}, Difficulty: {DifficultyLevel}";
        }
    }
}
