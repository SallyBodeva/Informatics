using RobotService.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P02_RobotService
{
    public class Robot
    {
        private string model;
        private int batteryLevel;
        private int batteryCapacity;
        private int convertionCapacityIndex;
        private IReadOnlyCollection<int> interfaceStandards;

        public Robot(string model, int batteryCapacity, int convertionCapacityIndex)
        {
            this.Model = model;
            this.BatteryCapacity = batteryCapacity;
            this.BatteryLevel = this.BatteryCapacity;
            this.ConvertionCapacityIndex = convertionCapacityIndex;
        }

        public string Model
        {
            get => model;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model cannot be null or empty.");
                }
                model = value;
            }
        }
        public int BatteryCapacity
        {
            get => batteryCapacity;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery capacity cannot drop below zero.");
                }
                batteryCapacity = value;
            }
        }
        public int BatteryLevel { get => batteryLevel; set => batteryLevel = value; }
        public int ConvertionCapacityIndex { get => convertionCapacityIndex; set => convertionCapacityIndex = value; }
        public IReadOnlyCollection<int> InterfaceStandards { get => interfaceStandards; set => interfaceStandards = value; }
        public void Eating(int minutes)
        {
            int producedEnergy = minutes * this.ConvertionCapacityIndex;
            if (this.BatteryLevel == this.BatteryCapacity)
            {
                return;
            }
            this.BatteryLevel += producedEnergy;
        }
        public void InstallSupplement(Supplement supplement)
        {
            this.InterfaceStandards.ToList().Add(supplement.InterfaceStandard);
            this.BatteryLevel -= supplement.BatteryUsage;
            this.BatteryCapacity -= supplement.BatteryUsage;
        }
        public bool ExecuteService(int consumedEnergy)
        {
            if (this.BatteryLevel >= consumedEnergy)
            {
                this.BatteryLevel -= consumedEnergy;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{GetType().Name} {Model}:");
            sb.AppendLine($"--Maximum battery capacity: {BatteryCapacity}");
            sb.AppendLine($"--Current battery level: {BatteryLevel}");
            if (this.InterfaceStandards.Count == 0)
            {
                sb.AppendLine($"--Supplements installed: none");
            }
            else
            {
                sb.AppendLine($"--Supplements installed:");
                this.InterfaceStandards.ToList().ForEach(x => sb.Append(x));
            }
            return sb.ToString().TrimEnd();
        }
    }
}
