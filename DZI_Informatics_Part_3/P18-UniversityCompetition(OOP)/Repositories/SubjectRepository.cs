using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P18_UniversityCompetition_OOP_.Models;
using UniversityCompetition.Repositories.Contracts;

namespace P18_UniversityCompetition_OOP_.Repositories
{
    internal class SubjectRepository : IRepository<Subject>
    {
        private List<Subject> models = new List<Subject>();
        public IReadOnlyCollection<Subject> Models => models.AsReadOnly();

        public void AddModel(Subject model)
        {
            models.Add(model);
        }

        public Subject FindById(int id)
        {
            return models.FirstOrDefault(x => x.Id == id);
        }

        public Subject FindByName(string name)
        {
            return models.FirstOrDefault(x => x.Name == name);
        }
    }
}
