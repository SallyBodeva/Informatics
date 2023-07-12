using RobotService.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P02_RobotService
{
    public class RobotRepository
    {
        List<Robot> robots;
        public RobotRepository()
        {
            this.robots = new List<Robot>();
        }
        public IReadOnlyCollection<Robot> Models()
        {
            return robots;
        }
        public void AddNew(Robot robot)
        {
            this.robots.Add(robot);
        }
        public bool RemoveByName(string robotModel)
        {
            var r = this.robots.FirstOrDefault(x => x.Model == robotModel);
            return this.robots.Remove(r);
        }
        public Robot FindByStandard(int interfaceStandard)
        {
            return this.robots.FirstOrDefault(x => x.InterfaceStandards.Contains(interfaceStandard));
        }
    }
}
