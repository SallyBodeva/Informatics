using System;
using System.Collections.Generic;
using System.Text;

namespace P01_E_DriveRent
{
    public class CargoVan : Vehicle
    {
        public CargoVan(string brand, string model, string licensePlateNumber) : base(brand, model, 180, licensePlateNumber)
        {
        }
        public override void Drive(double mileage)
        {
            base.Drive(mileage);
            this.BatteryLevel -= 5;
        }
    }
}
