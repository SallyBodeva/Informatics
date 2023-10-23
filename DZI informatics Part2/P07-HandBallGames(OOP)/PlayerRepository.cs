using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace P07_HandBallGames_OOP_
{
    public class PlayerRepository
    {
        private readonly List<Player> models;
        public void AddModel(Player player)
        {
            models.Add(player);
        }
        public bool RemoveModel(string name)
        {
            Player p = models.FirstOrDefault(x => x.Name == name);
            return this.models.Remove(p);
        }
        public bool ExistsModel(string name)
        {
            return models.Any(x => x.Name == name);
        }
        public Player GetModel(string name)
        {
            return models.FirstOrDefault(x => x.Name == name);
        }
    }
}
