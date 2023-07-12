using RobotService.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P02_RobotService
{
    public class Supplement : ISupplement
    {
        private int interfaceStandard;
        private int batteryUsage;

        public Supplement(int interfaceStandard, int batteryUsage)
        {
            this.InterfaceStandard = interfaceStandard;
            this.BatteryUsage = batteryUsage;
        }

        public int InterfaceStandard
        {
            get => interfaceStandard;
            set
            {
                interfaceStandard = value;
            }
        }
        public int BatteryUsage
        {
            get => batteryUsage; 
            set
            {
                batteryUsage = value;
            }
        }
    }
}
