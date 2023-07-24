using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03_UniversityCompetition
{
    public class SubjectRepository
    {
        private List<Subject> subjects;
        public SubjectRepository()
        {
            subjects = new List<Subject>();
        }
        public int Count()
        {
            return subjects.Count;
        }
        public void AddModel(Subject subject)
        {
            this.subjects.Add(subject);
        }
        public Subject FindById(int id)
        {
            return this.subjects.FirstOrDefault(x => x.Id == id);
        }
        public Subject FindByName(string name)
        {
            return this.subjects.FirstOrDefault(x => x.Name == name);
        }
    }
}
