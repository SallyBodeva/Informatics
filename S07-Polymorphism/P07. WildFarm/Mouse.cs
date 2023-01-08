using System;
using System.Collections.Generic;
using System.Text;


public class Mouse : Mammal
{
    public Mouse(string name, double weight, int foodEaten, string livingregion) : base(name, weight, foodEaten, livingregion)
    {
    }

    public override string AskForFood()
    {
        return "Squeak";
    }
    public override string ToString()
    {
        return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}

