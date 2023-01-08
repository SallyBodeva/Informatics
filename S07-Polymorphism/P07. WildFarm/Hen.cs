using System;
using System.Collections.Generic;
using System.Text;


public class Hen : Bird
{
    public Hen(string name, double weight, int foodEaten, double wingsize) : base(name, weight, foodEaten, wingsize)
    {
    }

    public override string AskForFood()
    {
        return "Cluck";
    }
}

