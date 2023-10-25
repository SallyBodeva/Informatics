using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace P07_HandBallGames_OOP_
{
    public class TeamRepository
    {
        public  List<Team> Models { get;}
        public void AddModel(Team team)
        {
            Models.Add(team);
        }
        public bool RemoveModel(string name)
        {
            Team t = Models.FirstOrDefault(x => x.Name == name);
            return Models.Remove(t);
        }
        public bool ExistsModel(string name)
        {
            if (Models.FirstOrDefault(x => x.Name == name) == null)
            {
                return false;
            }
            return true;
        }
        public Team GetModel(string name)
        {
            return Models.FirstOrDefault(x => x.Name == name);
        }
    }
}
