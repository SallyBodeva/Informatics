using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P18_UniversityCompetition_OOP_.Models;
using UniversityCompetition.Repositories.Contracts;

namespace P18_UniversityCompetition_OOP_.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        private List<Student> models = new List<Student>();
        public IReadOnlyCollection<Student> Models => models.AsReadOnly();

        public void AddModel(Student model)
        {
            models.Add(model);
        }

        public Student FindById(int id)
        {
            return models.FirstOrDefault(x => x.Id == id);
        }

        public Student FindByName(string name)
        {
            string[] fullname = name.Split(" ");
            string firstName = fullname[0];
            string lastName = fullname[1];
            return models.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

        }
    }
}
