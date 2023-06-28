using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03_AutomotiveRepairShop
{
    public class RepairShop
    {
        private List<Vehicle> vehicles;
        private int capacity;

        public RepairShop(int capacity)
        {
            this.Capacity = capacity;
            this.vehicles = new List<Vehicle>();
        }

        public int Capacity
        {
            get { return capacity; }
            set
            {
                capacity = value;
            }
        }
        public void AddVehicle(Vehicle vehicle)
        {
            if (Capacity>this.vehicles.Count)
            {
                this.vehicles.Add(vehicle);
            }
        }
        public bool  RemoveVehicle(string vin)
        {
            Vehicle v = this.vehicles.FirstOrDefault(x => x.VIN == vin);
            return this.vehicles.Remove(v);
        }
        public int GetCount()
        {
            return this.vehicles.Count;
        }
        public Vehicle GetLowestMileage()
        {
            return this.vehicles.OrderBy(x => x.Mileage).First();
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Vehicles in the preparatory:");
            this.vehicles.ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString().TrimEnd();
        }
    }
}
