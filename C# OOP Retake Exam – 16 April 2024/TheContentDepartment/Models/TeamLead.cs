using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheContentDepartment.Models
{
    public class TeamLead : TeamMember
    {
        public TeamLead(string name, string path) : base(name, path)
        {
           
        }
        public override string Path
        {
            get { return base.Path; }
            set
            {
                if (value!="Master")
                {
                    throw new ArgumentException($"{value} path is not valid.");
                }
                base.Path = value;
            }
        }
        public override string ToString()
        {
            return $"{this.Name} ({this.GetType().Name}) – Currently working on {this.InProgress.Count} tasks.";
        }
    }
}
