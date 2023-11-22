using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

public class TreePlant : Plant
{
    private double height;

    public TreePlant(int id, string name, double humidityLevel, double fertilityLevel,int height) : base(id, name, "tree", humidityLevel, fertilityLevel)
    {
        this.Height = height;
    }
    public double Height
    {
        get { return height; }
        set
        {
            if (value<0)
            {
                throw new ArgumentException("Height should be positive!");
            }
            height = value;
        }
    }
    public override string ToString()
    {
        string info = base.ToString();
        return (info += $"\nHeight: {Height}").ToString();
    }
}

