using RobotService.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace P02_RobotService
{
    public class Controller : IController
    {
        private SupplementRepository supplements;
        private RobotRepository robots;
        public Controller()
        {
            supplements = new SupplementRepository();
            robots = new RobotRepository();
        }

        public string CreateRobot(string model, string typeName)
        {
            if (typeName != nameof(DomesticAssistant) && typeName != nameof(IndustrialAssistant))
            {
                return $"Robot type {typeName} cannot be created.";
            }
            Robot r = null;
            switch (typeName)
            {
                case "DomesticAssistant":
                    r = new DomesticAssistant(model);
                    break;
                case "IndustrialAssistant":
                    r = new IndustrialAssistant(model);
                    break;
            }
            robots.AddNew(r);
            return $"{typeName} {model} is created and added to the RobotRepository.";
        }

        public string CreateSupplement(string typeName)
        {
            if (typeName != nameof(SpecializedArm) && typeName != nameof(LaserRadar))
            {
                return $"{typeName} is not compatible with our robots.";
            }
            Supplement s = null;
            switch (typeName)
            {
                case "SpecializedArm":
                    s = new SpecializedArm();
                    break;
                case "LaserRadar":
                    s = new LaserRadar();
                    break;
            }
            supplements.AddNew(s);
            return $"{typeName} is created and added to the SupplementRepository.";
        }

        public string PerformService(string serviceName, int intefaceStandard, int totalPowerNeeded)
        {
            var neededRobots = robots.Models().Where(x => x.InterfaceStandards.Any(i => i == intefaceStandard)).OrderByDescending(y=>y.BatteryLevel).ToList();
            if (neededRobots.Count == 0)
            {
                return "Unable to perform service, {intefaceStandard} not supported!";
            }
            int sumOfBateries = neededRobots.Sum(x => x.BatteryLevel);
            if (sumOfBateries < totalPowerNeeded)
            {
                return $"{serviceName} cannot be executed! {totalPowerNeeded - sumOfBateries} more power needed.";
            }
            int usedRobotsCount = 0;

            foreach (var robot in neededRobots)
            {
                usedRobotsCount++;

                if (totalPowerNeeded <= robot.BatteryLevel)
                {
                    robot.ExecuteService(totalPowerNeeded);
                    break;
                }
                else
                {
                    totalPowerNeeded -= robot.BatteryLevel;
                    robot.ExecuteService(robot.BatteryLevel);
                }
            }
            return $"{serviceName} is performed successfully with {usedRobotsCount} robots.";


        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var r in robots.Models().OrderByDescending(x => x.BatteryLevel).ThenBy(x => x.BatteryCapacity))
            {
                sb.AppendLine(r.ToString());
            }
            return sb.ToString().TrimEnd();
        }

        public string RobotRecovery(string model, int minutes)
        {
            List<Robot> selectedRobots = this.robots.Models().Where(x => x.Model == model && x.BatteryLevel < 50).ToList();
            foreach (var r in selectedRobots)
            {
                r.Eating(minutes);
            }
            return $"Robots fed: {selectedRobots.Count}";
        }

        public string UpgradeRobot(string model, string supplementTypeName)
        {
            IReadOnlyCollection<Supplement> supps = this.supplements.Models();
            Supplement s = supps.FirstOrDefault(x => x.GetType().Name == supplementTypeName);
            int interfaceValue = s.InterfaceStandard;
            IReadOnlyCollection<Robot> robs = this.robots.Models().Where(x => !x.InterfaceStandards.Contains(interfaceValue)).ToList();
            List<Robot> neededRobos = robs.Where(x => x.Model == model).ToList();
            if (neededRobos.Count == 0)
            {
                return $"All {model} are already upgraded!";
            }
            else
            {
                neededRobos.First().InstallSupplement(s);
                this.supplements.RemoveByName(supplementTypeName);
                return $"{model} is upgraded with {supplementTypeName}.";
            }
        }
    }
}
