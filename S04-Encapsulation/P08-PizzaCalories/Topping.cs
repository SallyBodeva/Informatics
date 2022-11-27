using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
public class Topping
{
    private readonly double caloriesPerGram;

    private double Meat = 1.2;
    private double Veggies = 0.8;
    private double Cheese = 1.1;
    private double Sauce = 0.9;

    private string type;
    private double weight;

    public Topping(string type, double weight)
    {
        this.Type = type;
        this.Weight = weight;
    }

    public string Type
    {
        get { return type; }
        private set
        {
            if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            type = value;
        }
    }
    public double Weight
    {
        get { return weight; }
        private set
        {
            if (value<0|| value>50)
            {
                throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
            }
            weight = value;
        }
    }
    public double CaloriesPerGram
    {
        get
        {
            double type = 0;
            switch (this.Type.ToLower())
            {
                case "meat":
                    type = Meat;
                    break;
                case "veggies":
                    type = Veggies;
                    break;
                case "cheese":
                    type = Cheese;
                    break;
                case "sauce":
                    type = Sauce;
                    break;
            }
            return 2 * this.Weight * type;
        }
    }
}

