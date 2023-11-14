using System;
using System.Collections.Generic;
using System.Text;


public abstract class Component
{
    private string model;
    private double price;
    private int generation;

    public string Model
    {
        get { return model; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Model cannot be null or empty!");
            }
            model = value;
        }
    }
    public double Price
    {
        get { return price; }
        set
        {
            if (value < 0 || value > 10000)
            {
                throw new ArgumentException("Nothing is for free!!! Price cannot be less or equal to 0 and more than 10000!");
            }
            price = value;
        }
    }
    public virtual int Generation
    {
        get { return generation; }
        set
        {
            if (value<=0)
            {
                throw new ArgumentException("Generation cannot be 0 or negative!");
            }
            generation = value;
        }
    }
    public abstract int LifeWorkingHours { get; }
}

