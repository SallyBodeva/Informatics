using RobotService.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P02_RobotService
{
    public class SupplementRepository
    {
        private List<Supplement> supplements;
        public SupplementRepository()
        {
            supplements = new List<Supplement>();
        }
        public IReadOnlyCollection<Supplement> Models()
        {
            return supplements.AsReadOnly();
        }
        public void AddNew(Supplement supplement)
        {
            this.supplements.Add(supplement);
        }
        public bool RemoveByName(string typeName)
        {
            Supplement s = this.supplements.FirstOrDefault(x => x.GetType().Name == typeName);
            return this.supplements.Remove(s);
        }
        public Supplement FindByStandard(int interfaceStandard)
        {
            return this.supplements.FirstOrDefault(x => x.InterfaceStandard == interfaceStandard);
        }
    }
}
