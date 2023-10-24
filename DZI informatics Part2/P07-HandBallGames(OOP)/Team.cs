using P07_HandBallGames_OOP_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Linq;

namespace P07_HandBallGames_OOP_
{
    public class Team
    {
        private readonly int overallRating;
        private string name;
        public List<Player>Players { get; set; }
        public Team(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get => name; set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Team name cannot be null or empty.");
                }
                name = value;
            }
        }
        public int PointsEarned { get; set; } = 0;
        public double OverallRating
        {
            get
            {
                if (Players.Count==0)
                {
                    return 0;
                }
                return Players.Average(x=>x.Rating);
            }
        }
        public void SignContract(Player player)
        {
            Players.Add(player);
            player.JoinTeam(this.Name);
        }
        public void Win()
        {
            this.PointsEarned += 3;
            foreach (var p in Players)
            {
                p.IncreaseRating();
            }
        }
        public void Lose()
        {
            foreach (var p in Players)
            {
                p.DecreaseRating();
            }
        }
        public void Draw()
        {
            this.PointsEarned += 1;
            Players.FirstOrDefault(x => x.GetType().Name == "GoalKeeper").IncreaseRating();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Team: {Name} Points: {PointsEarned}");
            sb.AppendLine($"--Overall rating: {OverallRating}");
            sb.Append("--Players: ");
            if (Players.Count!=0)
            {
                Players.ForEach(x => sb.Append(x.Name));
            }
            sb.AppendLine("none");
            return sb.ToString().TrimEnd();
        }
    }
}