using System;
using System.Collections.Generic;
using System.Text;


public class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
        
    }

    public override void Drive(double km)
    {
        if (FuelQuantity>=(0.9+FuelConsumption)*km)
        {
            FuelQuantity -= km*(FuelConsumption+0.9);
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
        else if (litters <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
        }
        else if (true)
        {
            FuelQuantity += litters;
        }
    }
}

