using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models.Contracts;

namespace P18_UniversityCompetition_OOP_.Models
{
    public class University : IUniversity
    {
        private int id;
        private string name;
        private string category;
        private int capacity;
        private List<int> requiredSubjects = new List<int>();


        public University(int id, string name, string category, int capacity, List<int> requiredSubjects)
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.Capacity = capacity;
            this.requiredSubjects = requiredSubjects;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
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
            get
            {
                return category;
            }
            set
            {
                if (value!="Technical" && value!="Economical" && value!="Humanity")
                {
                    throw new ArgumentException($"University category {value} is not allowed in the application!");
                }
                category = value;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("University capacity cannot be a negative value!\"");
                }
                capacity = value;
            }
        }

        public IReadOnlyCollection<int> RequiredSubjects => this.requiredSubjects;
    }
}
