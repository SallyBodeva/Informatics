using System;
using System.Collections.Generic;
using System.Text;


public abstract class Mammal:Animal
{
    protected Mammal(string name, double weight, int foodEaten, string livingregion) : base(name, weight, foodEaten)
    {
        this.LivingRegion = livingregion;
    }

    public string LivingRegion { get; set; }
}

