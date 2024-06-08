using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheContentDepartment.Models.Contracts;

namespace TheContentDepartment.Models
{
    public abstract class TeamMember : ITeamMember
    {
        private List<string> resources = new List<string>();
        private string name;

        protected TeamMember(string name, string path)
        {
            this.Name = name;
            this.Path = path;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace.");
                }
                name = value;
            }
        }

        public virtual string Path { get; set; }

        public IReadOnlyCollection<string> InProgress
        {
            get
            {
                return resources.AsReadOnly();
            }
        }

        public void FinishTask(string resourceName)
        {
            this.resources.Remove(this.resources.FirstOrDefault(x => x == resourceName));
        }

        public void WorkOnTask(string resourceName)
        {
            this.resources.Add(resourceName);
        }
    }
}
