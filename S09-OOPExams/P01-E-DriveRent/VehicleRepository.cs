using EDriveRent.Models.Contracts;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace P01_E_DriveRent
{
    public class VehicleRepository : IReadOnlyCollection<Vehicle>
    {
        private readonly List<Vehicle> vehicles;
        public VehicleRepository()
        {
            vehicles = new List<Vehicle>();
        }
        public ReadOnlyCollection<Vehicle> Vehicles
        {
            get { return this.vehicles.AsReadOnly(); }
        }
        public void AddModel(Vehicle vehicle)
        {
            this.vehicles.Add(vehicle);
        }
        public bool RemoveById(string identifier)
        {
            return this.vehicles.Remove(vehicles.FirstOrDefault(x => x.LicensePlateNumber == identifier));
        }
        public Vehicle FindById(string identifier)
        {
            return this.vehicles.FirstOrDefault(x => x.LicensePlateNumber == identifier);
        }
        public IReadOnlyCollection<Vehicle> GetAll()
        {
            return Vehicles;
        }
        public int Count => this.vehicles.Count();

        public IEnumerator<Vehicle> GetEnumerator()
        {
            for (int i = 0; i < this.vehicles.Count; i++)
            {
                yield return vehicles[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
