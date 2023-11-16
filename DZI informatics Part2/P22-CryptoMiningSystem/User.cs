using System;
using System.Collections.Generic;
using System.Text;

public class User
{
    private readonly int stars;
    private string name;
    private double money;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Username must not be null or empty!");
            }
            name = value;
        }
    }

    public int Stars
    {
        get
        {
            int s = int.Parse(Math.Floor(this.Money).ToString());
            return s / 100; 
        }
    }

    public double Money
    {
        get { return money; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("User's money cannot be less than 0!");
            }
            money = value;
        }
    }

    public Computer Computer { get; set; }

}
