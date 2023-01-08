using System;
using System.Collections.Generic;
using System.Text;


public abstract class Animal
{
    protected Animal(string name, double weight, int foodEaten)
    {
        this.Name = name;
        this.Weight = weight;
        this.FoodEaten = foodEaten;
    }

    public string Name { get; set; }
    public double Weight { get; set; }
    public int FoodEaten { get; set; }
    public abstract string AskForFood();
}

