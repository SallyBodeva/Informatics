using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace P07_HandBallGames_OOP_
{
    public class Controller
    {
        private PlayerRepository players;
        private TeamRepository teams;

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

        }
    }
}
