using System;
using System.Collections.Generic;
using System.Text;

namespace P07_HandBallGames_OOP_
{
    public abstract class Player
    {
        private string name;

        protected Player(string name, double rating)
        {
            this.Name = name;
            this.Rating = rating;
        }

        public string Name
        {
            get => name; 
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Player name cannot be null or empty.");
                }
                name = value;
            }
        }
        public double Rating { get; set; }
        public string Team  { get; set; }

        public void JoinTeam(string teamName)
        {
            this.Name = teamName;
        }
        public abstract void IncreaseRating();
        public abstract void DecreaseRating();
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{GetType().Name}: {Name}");
            sb.AppendLine($"--Rating: {Rating}");
            return sb.ToString().TrimEnd(); 
        }
    }
}