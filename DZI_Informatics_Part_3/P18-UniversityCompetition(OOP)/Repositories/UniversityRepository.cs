using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P18_UniversityCompetition_OOP_.Models;
using UniversityCompetition.Repositories.Contracts;

namespace P18_UniversityCompetition_OOP_.Repositories
{
    public class UniversityRepository : IRepository<University>
    {
        private List<University> models = new List<University>();
        public IReadOnlyCollection<University> Models => models.AsReadOnly();

        public void AddModel(University model)
        {
            models.Add(model);
        }

        public University FindById(int id)
        {
            return models.FirstOrDefault(x => x.Id == id);
        }

        public University FindByName(string name)
        {
            return models.FirstOrDefault(x => x.Name == name);

        }
    }
}
