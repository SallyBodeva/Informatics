using System;
using System.Collections.Generic;
using System.Text;


public class Tiger : Feline
{
    public Tiger(string name, double weight, int foodEaten, string livingregion) : base(name, weight, foodEaten, livingregion)
    {
    }

    public override string AskForFood()
    {
        return "ROAR!!!";
    }
}

