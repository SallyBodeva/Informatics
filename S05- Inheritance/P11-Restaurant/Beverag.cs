using System;
using System.Collections.Generic;
using System.Text;


public class Beverag : Product
{
    public Beverag(string name, decimal price, double millilliters) : base(name, price)
    {
        this.Millilliters = millilliters;
    }
    public double Millilliters { get;private set; }
}

