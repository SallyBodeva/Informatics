using EDriveRent.Core.Contracts;
using EDriveRent.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace P01_E_DriveRent
{
    public class Controller : IController
    {
        private UserRepository users;
        private VehicleRepository vehicles;
        private RouteRepository routes;

        public Controller()
        {
            this.users = new UserRepository();
            this.vehicles = new VehicleRepository();
            this.routes = new RouteRepository();
        }

        public string AllowRoute(string startPoint, string endPoint, double length)
        {
            int routeId = this.routes.GetAll().Count + 1;

            Route existingRoute = this.routes
                .GetAll()
                .FirstOrDefault(r => r.StartPoint == startPoint && r.EndPoint == endPoint);

            if (existingRoute != null)
            {
                if (existingRoute.Length == length)
                {
                    return $"{startPoint}/{endPoint} - {length} km is already added in our platform.";
                }
                else if (existingRoute.Length < length)
                {
                    return $"{startPoint}/{endPoint} shorter route isalready added in our platform.";
                }
                else if (existingRoute.Length > length)
                {
                    existingRoute.LockRoute();
                }
            }
            Route newRoute = new Route(startPoint, endPoint, length, routeId);
            this.routes.AddModel(newRoute);

            return $"{startPoint}/{endPoint} - {length} km is unlocked in our platform.";

        }

        public string MakeTrip(string drivingLicenseNumber, string licensePlateNumber, string routeId, bool isAccidentHappened)
        {
            User u = this.users.FindById(drivingLicenseNumber);
            Vehicle v = this.vehicles.FindById(licensePlateNumber);
            Route r = this.routes.FindById(routeId);
            if (u.IsBlocked==true)
            {
                return $"User {drivingLicenseNumber} is blocked in the platform!Trip is not allowed.";
            }
            if (v.IsDamaged==true)
            {
                return $"Vehicle {licensePlateNumber} is damaged! Trip is not allowed.";
            }
            if (r.IsLocked==true)
            {
                return $"Route {routeId} is locked! Trip is not allowed.";
            }
            v.Drive(r.Length);
            if (isAccidentHappened==true)
            {
                v.ChangeStatus();
                u.DecreaseRating();
            }
            else
            {
                u.IncreaseRating();
            }
            return $"{v.Model}License plate: {v.LicensePlateNumber} Battery: {v.BatteryLevel}% Status:OK / damaged";

        }

        public string RegisterUser(string firstName, string lastName, string drivingLicenseNumber)
        {
            var u = this.users.FindById(drivingLicenseNumber);
            if (u!=null)
            {
                return $"{drivingLicenseNumber} is already registered in our platform.";
            }
            else
            {
                users.AddModel(new User(firstName, lastName, drivingLicenseNumber));
                return $"{firstName} {lastName} is registered successfully with DLN-{drivingLicenseNumber}";
            }
        }

        public string RepairVehicles(int count)
        {
            int c =0;
            List<Vehicle> demagedV = vehicles.Where(x => x.IsDamaged == true).ToList();
            demagedV.OrderBy(x => x.Brand).ThenBy(x => x.Model);
            if (count>demagedV.Count)
            {
                foreach (var item in demagedV)
                {
                    item.IsDamaged = false;
                    item.BatteryLevel = 100;
                }
                c = demagedV.Count;
            }
            else
            {
                List<Vehicle> neededVehicle = demagedV.Take(count).ToList();
                for (int i = 0; i < neededVehicle.Count; i++)
                {
                    neededVehicle[i].IsDamaged = false;
                    neededVehicle[i].BatteryLevel = 100;
                }
                c=neededVehicle.Count;
            }
            return $"{c} vehicles are successfully repaired!";

        }

        public string UploadVehicle(string vehicleType, string brand, string model, string licensePlateNumber)
        {
            if (vehicleType!=nameof(PassengerCar) && vehicleType!=nameof(CargoVan))
            {
                return $"{vehicleType} is not accessible in our platform.";
            }
            var v = vehicles.FindById(licensePlateNumber);
            if (v!=null)
            {
                return $"{licensePlateNumber} belongs to another vehicle.";
            }
            else
            {
                switch (vehicleType)
                {
                    case "CargoVan":
                        v = new CargoVan(brand, model, licensePlateNumber);
                        break;
                    case "PassengerCar":
                        v = new PassengerCar(brand, model, licensePlateNumber);
                        break;
                }
                vehicles.AddModel(v);
                return $"{brand} {model} is uploaded successfully with LPN -{licensePlateNumber}";
            }
        }

        public string UsersReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*** E-Drive-Rent ***");
            foreach (var item in users.GetAll().OrderByDescending(x => x.Rating).ThenBy(x => x.LastName).ThenBy(x => x.FirstName))
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
