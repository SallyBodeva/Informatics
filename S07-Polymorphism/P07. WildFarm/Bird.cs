using System;
using System.Collections.Generic;
using System.Text;


public abstract class Bird:Animal
{
    protected Bird(string name, double weight, int foodEaten,double wingsize) : base(name, weight, foodEaten)
    {
        this.WingSize = wingsize;
    }

    public double WingSize { get; set; }
    public override string ToString()
    {
        return $"{this.GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
    }
}

