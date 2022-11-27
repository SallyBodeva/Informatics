using System;
using System.Collections.Generic;
using System.Text;


public class Box
{
    private double length;
    private double width;
    private double heigth;

    public Box(double length, double width, double heigth)
    {
        this.Length = length;
        this.Width = width;
        this.Heigth = heigth;
    }

    public double Length
    {
        get { return length; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            length = value;
        }
    }
    public double Width
    {
        get { return width; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            width = value;
        }
    }
    public double Heigth
    {
        get { return heigth; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Heigth cannot be zero or negative.");
            }
            heigth = value;
        }
    }
    public string SurfaceArea()
    {
        return $"Surface Area - {2*this.Length*this.Width+2*this.Length*this.Heigth+2*this.Width*this.Heigth:f2}";
    }
    public string LateralSurfaceArea()
    {
        return $"Lateral Surface Area - {2*this.Length*this.Heigth+2*this.Width*this.Heigth:f2}";
    }
    public string Volume()
    {
        return $"Volume - {this.Length * this.Width*this.Heigth:f2}";
    }
}
