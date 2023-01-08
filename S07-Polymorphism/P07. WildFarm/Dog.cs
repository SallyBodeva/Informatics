using System;
using System.Collections.Generic;
using System.Text;


public class Dog : Mammal
{
    public Dog(string name, double weight, int foodEaten, string livingregion) : base(name, weight, foodEaten, livingregion)
    {
    }

    public override string AskForFood()
    {
        return "Woof!";
    }
}

