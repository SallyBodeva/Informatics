using System;
using System.Collections.Generic;
using System.Text;


public class FloweringPlant:Plant
{
    private string color;

    public FloweringPlant(int id, string name,double humidityLevel, double fertilityLevel,string color) : base(id, name, "flower", humidityLevel, fertilityLevel)
    {
        this.Color = color;
    }

    public string Color
    {
        get { return color; }
        set
        {
            if (value.Length<3 || value.Length>30)
            {
                throw new ArgumentException("Color should be between 3 and 30 characters!");
            }
            color = value;
        }
    }
    public override string ToString()
    {
        string info = base.ToString();
        return (info+=$"\nColor: {Color}").ToString();
    }
}

