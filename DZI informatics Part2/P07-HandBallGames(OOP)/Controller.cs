using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace P07_HandBallGames_OOP_
{
    public class Controller
    {
        private PlayerRepository players = new PlayerRepository();
        private TeamRepository teams = new TeamRepository();

        public string NewTeam(string name)
        {
            if (teams.ExistsModel(name))
            {
                return $"{name} is already added to the {players.GetType().Name}.";
            }
            Team t = new Team(name);
            teams.AddModel(t);
            return $"{name} is successfully added to the {players.GetType().Name}.";
        }
        public string NewPlayer(string typeName,string name)
        {
            if (typeName!= nameof(Goalkeeper) && typeName!= nameof(CenterBack) && typeName!= nameof(ForwardWing))
            {
                return $"{typeName} is invalid position for the application.";
            }
            if (players.ExistsModel(name))
            {
                return $"{name} is already added to the {players.GetType().Name} as {players.GetModel(name).GetType().Name}.";
            }
            Player p = null;
            switch (typeName.ToLower())
            {
                case "goalkeeper":
                    p = new Goalkeeper(name);
                    break;
                case "centerback":
                    p = new CenterBack(name);
                    break;
                case "forwardwing":
                    p = new ForwardWing(name);
                    break;
            }
            players.AddModel(p);
            return $"{name} is filed for the handball league.";
        }
        public string NewContract(string playerName, string teamName)
        {
            if (!players.ExistsModel(playerName))
            {
                return $"Player with the name {playerName} does not exist in the {nameof(PlayerRepository)}.";
            }
            if (!teams.ExistsModel(teamName))
            {
                return $"Team with the name {teamName} does not exist in the {nameof(TeamRepository)}.";
            }
            Player p = players.GetModel(playerName);
            if (p.Team!=null)
            {
                return $"Player {playerName} has already signed with {p.Team}.";
            }
            p.Team=teamName;
            Team t = teams.GetModel(teamName);
            t.SignContract(p);
            return $"Player {playerName} signed a contract with {teamName}.";
        }
        public string NewGame(string firstTeamName, string secondTeamName)
        {
            Team t1 = teams.GetModel(firstTeamName);
            Team t2 = teams.GetModel(secondTeamName);
            if (t1.OverallRating>t2.OverallRating)
            {
                t1.Win();
                t2.Lose();
                return $"Team {t1.Name} wins the game over {t2.Name}!";
            }
            else if (t1.OverallRating<t2.OverallRating)
            {
                t1.Lose();
                t2.Win();
                return $"Team {t2.Name} wins the game over {t1.Name}!";
            }
            else
            {
                t1.Draw();
                t2.Draw();
                return $"The game between {t1.Name} and {t2.Name} ends in a draw!";
            }
        }
        public string PlayerStatistics(string teamName)
        {
            StringBuilder sb = new StringBuilder();
            Team t = teams.GetModel(teamName);
            sb.AppendLine($"***{t.Name}***");
            foreach (var player in t.Players.OrderByDescending(x=>x.Rating).ThenBy(x=>x.Name))
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().TrimEnd();
        }
        public string LeagueStandings()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***League Standings***");
            foreach (var team in teams.Models.OrderByDescending(x=>x.OverallRating).ThenBy(x=>x.Name))
            {
                sb.AppendLine(team.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
