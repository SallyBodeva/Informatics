using System;
using System.Collections.Generic;
using System.Text;


public class Pizza
{
    private readonly double totalCalories;
    private string name;
    private List<Topping> toppings;

    public Pizza(string name)
    {
        this.Name = name;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            name = value;
        }
    }
    public Dough Dough { get;  set; }
    public List<Topping> Toppings
    {
        get { return toppings; }
        set
        {
            if (value.Count>10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            toppings = value;
        }
    }
    public double TotalCalories
    {
        get
        {
            double sumTop = 0;
            foreach (var item in this.Toppings)
            {
                sumTop += item.CaloriesPerGram;
            }
            return this.Dough.CaloriesPerGram + sumTop;
        }
    }
}

