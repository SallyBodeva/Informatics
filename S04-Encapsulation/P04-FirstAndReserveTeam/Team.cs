using PersonsInfo;
using System;
using System.Collections.Generic;
using System.Text;


public class Team
{
    public string Name { get; set; }
    public List<Person> firstTeam { get; }
    public List<Person> reserveTeam { get; }

    public Team()
    {
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
    }
    public void AddPerson(Person p)
    {
        if (p.Age < 40)
        {
            this.firstTeam.Add(p);
        }
        else
        {
            this.reserveTeam.Add(p);
        }
    }
}

