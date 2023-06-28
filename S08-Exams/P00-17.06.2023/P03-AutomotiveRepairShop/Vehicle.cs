using System;
using System.Collections.Generic;
using System.Text;

namespace P03_AutomotiveRepairShop
{
    public class Vehicle
    {
        private string vIN;
        private int mileage;
        private string damage;

        public Vehicle(string vIN, int mileage, string damage)
        {
            this.VIN = vIN;
            this.Mileage = mileage;
            this.Damage = damage;
        }

        public string VIN
        {
            get { return vIN; }
            set
            {
                vIN = value;
            }
        }
        public int Mileage
        {
            get { return mileage; }
            set
            {
                mileage = value;
            }
        }

        public string Damage
        {
            get { return Damage; }
            set { Damage = value; }
        }
        public override string ToString()
        {
            return $"Damage: {this.Damage}, Vehicle: {this.VIN} ({this.Mileage} km)";
        }
    }
}
