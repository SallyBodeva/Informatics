using System;
using System.Collections.Generic;
using System.Text;


public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    public override void Drive(double km)
    {
        if (FuelQuantity >= (FuelConsumption + 1.6) * km )
        {
            FuelQuantity -= km * (FuelConsumption+1.6);
            Console.WriteLine($"Truck travelled {km} km");
            Console.WriteLine(FuelQuantity);
        }
        else
        {
            Console.WriteLine("Truck needs refueling");
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


