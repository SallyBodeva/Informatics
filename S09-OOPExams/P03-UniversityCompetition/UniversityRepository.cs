using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03_UniversityCompetition
{
    public class UniversityRepository
    {
        private List<University> universities;
        public UniversityRepository()
        {
            universities = new List<University>();
        }
        public int Count()
        {
           return this.universities.Count;
        }
        public void AddModel(University university)
        {
            this.universities.Add(university);
        }
        public University FindById(int id)
        {
            return this.universities.FirstOrDefault(x => x.Id == id);
        }
        public University FindByName(string name)
        {
            return this.universities.FirstOrDefault(x => x.Name == name);
        }
    }
}
