using System;
using System.Collections.Generic;
using System.Text;


public class Owl : Bird
{
    public Owl(string name, double weight, int foodEaten, double wingsize) : base(name, weight, foodEaten, wingsize)
    {
    }

    public override string AskForFood()
    {
        return "Hoot Hoot";
    }
}

