using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace P07_HandBallGames_OOP_
{
    public class TeamRepository
    {
        private List<Team> models;
        public void AddModel(Team team)
        {
            models.Add(team);
        }
        public bool RemoveModel(string name)
        {
            Team t = models.FirstOrDefault(x => x.Name == name);
            return models.Remove(t);
        }
        public bool ExistsModel(string name)
        {
            return this.models.Any(x => x.Name == name);
        }
        public Team GetModel(string name)
        {
            return models.FirstOrDefault(x => x.Name == name);
        }
    }
}
