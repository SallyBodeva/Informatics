using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class VesselRepository
{
    public List<Vessel> Models { get; set; }

    public void Add(Vessel vessel)
    {
        this.Models.Add(vessel);
    }
    public bool Remove(Vessel vessel)
    {
         return this.Models.Remove(vessel);
    }
    public Vessel FindByName(string name)
    {
        return this.Models.FirstOrDefault(x => x.Name == name);
    }
}

