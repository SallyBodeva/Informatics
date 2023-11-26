using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Serialization;

namespace P01_SimilarNums
{
    public class Kindergarten
    {
        private List<Child> registry;

        public Kindergarten(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            registry = new List<Child>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }
        public bool AddChild(Child child)
        {
            if (this.registry.Count + 1 <= this.Capacity)
            {
                this.registry.Add(child);
                return true;
            }
            return false;
        }
        public bool RemoveChild(string childFullName)
        {
            string[] names = childFullName.Split(" ").ToArray();
            string firstName = childFullName[0].ToString();
            string lastName = childFullName[1].ToString();

            Child c = this.registry.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
            return this.registry.Remove(c);
        }
        public int ChildrenCount()
        {
            return this.registry.Count;
        }
        public Child GetChild(string childFullName)
        {
            string[] names = childFullName.Split(" ").ToArray();
            string firstName = childFullName[0].ToString();
            string lastName = childFullName[1].ToString();

            Child c = this.registry.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
            return c;
        }
        public string RegistryReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Registered children in {this.Name}:");
            this.registry.ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString().TrimEnd();
        }
    }
}
