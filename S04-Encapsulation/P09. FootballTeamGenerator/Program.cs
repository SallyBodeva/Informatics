using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        Dictionary<string, Team> teams = new Dictionary<string, Team>();
        while (true)
        {
            List<string> cmd = Console.ReadLine().Split(' ').ToList();
            switch (cmd[0])
            {
                case "END":
                    Environment.Exit(0);
                    break;
                case "Team":
                    Team team = new Team(cmd[1]);
                    teams.Add(cmd[1], team);
                    break;
                case "Add":
                    if (teams.Any(x => x.Key == cmd[1]))
                    {
                        Player p = new Player(cmd[2], int.Parse(cmd[3]), int.Parse(cmd[4]), int.Parse(cmd[5]), int.Parse(cmd[6]), int.Parse(cmd[7]));
                        Team theTeam = teams.FirstOrDefault(x => x.Key == cmd[1]).Value;
                        theTeam.AddPlayer(p);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}

