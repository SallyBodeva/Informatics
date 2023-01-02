using System;
using System.Collections.Generic;
using System.Text;


public class Pet
{
    public Pet(string name, string birhday)
    {
        this.Name = name;
        this.Birhday = birhday;
    }

    public string Name { get; set; }
    public string Birhday { get; set; }
}

