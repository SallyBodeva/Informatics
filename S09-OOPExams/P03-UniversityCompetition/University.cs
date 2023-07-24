using System;
using System.Collections.Generic;
using System.Text;

namespace P03_UniversityCompetition
{
    public class University
    {
        private int id;
        private string name;
        private string category;
        private int capacity;
        private List<int> requiredSubjects;

        public University(int id, string name, string category, int capacity, List<int> requiredSubjects)
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.Capacity = capacity;
            this.RequiredSubjects = requiredSubjects;
        }

        public int Id { get => id; private set => id = value; }
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }
                name = value;
            }
        }
        public string Category
        {
            get => category;
            private set
            {
                if (value != "Technical" && value != "Economical" && value != "Humanity")
                {
                    throw new ArgumentException($"University category {value} is not allowed in the application!");
                }
                category = value;
            }
        }
        public int Capacity
        {
            get => capacity;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("University capacity cannot be a negative value!");
                }
                capacity = value;
            }
        }
        public List<int> RequiredSubjects { get => requiredSubjects; set => requiredSubjects = value; }
    }
}
