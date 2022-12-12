using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class Team
{
    private readonly double rating;
    private readonly List<Player> players;
    private string name;

    public Team(string name)
    {
        this.Name = name;
        players = new List<Player>();
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }
            name = value;
        }
    }
    public double Rating
    {
        get
        {
            return this.players.Average(x => x.SkillLevel);
        }
    }
    public void AddPlayer(Player player)
    {
        this.players.Add(player);
    }
    public void RemovePlayer(Player player)
    {
        this.players.Remove(player);
    }
}

