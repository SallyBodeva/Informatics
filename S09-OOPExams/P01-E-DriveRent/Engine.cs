using EDriveRent.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace P01_E_DriveRent
{
    public class Engine : IEngine
    {
        private Controller controller;
        public Engine()
        {
            controller = new Controller();
        }
        public void Run()
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    Environment.Exit(0);
                }
                try
                {
                    string result = string.Empty;

                    if (input[0] == "RegisterUser")
                    {
                        string firstName = input[1];
                        string lastName = input[2];
                        string drivingLicenseNumber = input[3];

                        result = controller.RegisterUser(firstName, lastName, drivingLicenseNumber);
                    }
                    else if (input[0] == "UploadVehicle")
                    {
                        string vehicleType = input[1];
                        string brand = input[2];
                        string model = input[3];
                        string licensePlateNumber = input[4];

                        result = controller.UploadVehicle(vehicleType, brand, model, licensePlateNumber);
                    }
                    else if (input[0] == "AllowRoute")
                    {
                        string startPoint = input[1];
                        string endPoint = input[2];
                        double length = double.Parse(input[3]);

                        result = controller.AllowRoute(startPoint, endPoint, length);
                    }
                    else if (input[0] == "MakeTrip")
                    {
                        string drivingLicenseNumber = input[1];
                        string licensePlateNumber = input[2];
                        string routeId = input[3];
                        bool isAccidentHappened = bool.Parse(input[4]);

                        result = controller.MakeTrip(drivingLicenseNumber, licensePlateNumber, routeId, isAccidentHappened);
                    }
                    else if (input[0] == "RepairVehicles")
                    {
                        int count = int.Parse(input[1]);

                        result = controller.RepairVehicles(count);
                    }
                    else if (input[0] == "UsersReport")
                    {
                        result = controller.UsersReport();
                    }
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
