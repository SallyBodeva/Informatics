using System;
using System.Collections.Generic;
using System.Text;


public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
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
        FuelQuantity += 0.95* litters;
    }
}


