using System;
using System.Collections.Generic;
using System.Text;


public class Vehicle
{
    public Vehicle(double fuel, int horsePower)
    {
        this.Fuel = fuel;
        this.HorsePower = horsePower;
    }

    public double Fuel { get; set; }
    public int HorsePower { get; set; }
    public double DefaultFuelConsumption { get; set; } = 1.25;
    public virtual double FuelConsumption { get; set; }
    public void  Drive (double km)
    {
        this.Fuel -= km * FuelConsumption;
        System.Console.WriteLine(this.Fuel);
    }
}