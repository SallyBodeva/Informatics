using System;
using System.Collections.Generic;
using System.Text;


public class Circle : Shape
{
    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public double Radius { get; private set; }

    public override double CalculateArea()
    {
        return Math.PI * this.Radius * this.Radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * this.Radius;
    }
}

