using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P07_HandBallGames_OOP_
{
    public class Engine
    {
        private Controller controller;
        public Engine()
        {
            controller = new Controller();
            Run();
        }
        public string Run()
        {
            string commands = string.Empty;
            StringBuilder sb = new StringBuilder();
            while ((commands = Console.ReadLine()) != "Exit")
            {
                List<string> args = commands.Split(" ").ToList();
                switch (args[0])
                {
                    case "NewTeam":
                        sb.AppendLine(controller.NewTeam(args[1]));
                        break;
                    case "NewPlayer":
                        sb.AppendLine(controller.NewPlayer(args[1], args[2]));
                        break;
                    case "NewContract":
                        sb.AppendLine(controller.NewContract(args[1], args[2]));
                        break;
                    case "NewGame":
                        sb.AppendLine(controller.NewGame(args[1], args[2]));
                        break;
                    case "PlayerStatistics":
                        sb.AppendLine(controller.PlayerStatistics(args[1]));
                        break;
                    case "LeagueStandings":
                        sb.AppendLine(controller.LeagueStandings());
                        break;
                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}
