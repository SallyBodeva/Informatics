using System;
using System.Collections.Generic;
using System.Text;


public class Renault:ICar
{
    public Renault(string model, string color)
    {
        this.Model = model;
        this.Color = color;
    }

    public string Model { get; set; }
    public string Color { get; set; }
    public string Start()
    {
        return "Engine starts";
    }
    public string Stop()
    {
        return "Breaaak!";
    }
    public override string ToString()
    {
        return $"Renault - Model: {this.Model}, Colour: {this.Color}";
    }
}


