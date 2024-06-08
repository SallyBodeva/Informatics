using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheContentDepartment.Models.Contracts;

namespace TheContentDepartment.Models
{
    public abstract class Resource : IResource
    {
        private string name;

        public Resource(string name, string creator, int priority)
        {
            this.Name = name;
            this.Creator = creator;
            this.Priority = priority;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace.");
                }
                name = value;
            }
        }

        public string Creator { get; set; }

        public int Priority { get; set; }

        public bool IsTested { get; set; } = false;

        public bool IsApproved { get; set; } = false;

        public void Approve()
        {
            this.IsApproved = true;
        }

        public void Test()
        {
            this.IsTested = !IsTested;
        }
        public override string ToString()
        {
            return $"{this.Name} ({this.GetType().Name}), Created By: {this.Creator}";
        }
    }
}
