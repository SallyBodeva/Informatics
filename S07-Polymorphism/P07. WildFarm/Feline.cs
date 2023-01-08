using System;
using System.Collections.Generic;
using System.Text;


public abstract class Feline:Mammal
{
    protected Feline(string name, double weight, int foodEaten, string livingregion) : base(name, weight, foodEaten, livingregion)
    {
    }

    public string Breed { get; set; }
    public override string ToString()
    {
        return $"{GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}

