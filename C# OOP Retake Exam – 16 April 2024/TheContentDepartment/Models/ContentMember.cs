using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheContentDepartment.Models
{
    public class ContentMember : TeamMember
    {
        public ContentMember(string name, string path) : base(name, path)
        {
        }
        public override string Path
        {
            get { return base.Path; }
            set
            {
                if (value != "CSharp" && value != "Java" && value != "JavaScript" && value != "Python")
                {
                    throw new ArgumentException($"{value} path is not valid.");
                }
                base.Path = value;
            }
        }
        public override string ToString()
        {
            return $"{this.Name} - {this.Path} path. Currently working on {this.InProgress.Count} tasks.";
        }
    }
}
