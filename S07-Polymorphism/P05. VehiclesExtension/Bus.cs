using System;
using System.Collections.Generic;
using System.Text;


public class Bus : Vehicle
{
    public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    public override void Drive(double km)
    {

        if (FuelQuantity >= (1.4 + FuelConsumption) * km)
        {
            FuelQuantity -= km * (FuelConsumption + 1.4);
            Console.WriteLine($"Car travelled {km} km");
        }
        else
        {
            Console.WriteLine("Car needs refueling");
        }
    }

    public override void Refuel(double litters)
    {
        if (TankCapacity < litters)
        {
            Console.WriteLine($"Cannot fit {litters} fuel in the tank.");
        }
        else if (litters<=0)
        {
            Console.WriteLine("Fuel must be a positive number");
        }
        else if (true)
        {
            FuelQuantity += litters;
        }
    }
    public void DriveEmpty(double km)
    {
        if (FuelQuantity >= (FuelConsumption) * km)
        {
            FuelQuantity -= km * (FuelConsumption);
            Console.WriteLine($"Bus travelled {km} km");
        }
        else
        {
            Console.WriteLine("Bus needs refueling");
        }
    }
}

