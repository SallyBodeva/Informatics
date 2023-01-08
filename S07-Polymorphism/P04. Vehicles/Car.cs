using System;
using System.Collections.Generic;
using System.Text;


public class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
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
        FuelQuantity +=litters;
    }
}

