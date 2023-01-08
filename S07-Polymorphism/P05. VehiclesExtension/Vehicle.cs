using System;
using System.Collections.Generic;
using System.Text;


public abstract class Vehicle
{
    protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        if (fuelQuantity > tankCapacity)
        {
            this.FuelQuantity = 0;
        }
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
        this.TankCapacity = tankCapacity;
    }

    public double FuelQuantity { get;  set; }
    public double FuelConsumption  { get;  set; }
    public double TankCapacity { get;  set; }
    public abstract void Drive(double km);
    public abstract void Refuel(double litters);
}

