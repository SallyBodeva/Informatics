using System;
using System.Collections.Generic;
using System.Text;

public class Tesla:ICar,IElectricCar
{
    public Tesla(string model, string color, int battery)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = battery;
    }

    public string Model { get; set; }
    public string Color { get; set; }
    public int Battery { get; set; }
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
        return $"Tesla - Model: {this.Model}, Colour: {this.Color} with {this.Battery} batteries";
    }
}

