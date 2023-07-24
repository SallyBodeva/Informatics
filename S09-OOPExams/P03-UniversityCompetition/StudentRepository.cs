using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace P03_UniversityCompetition
{
    public class StudentRepository
    {
        private List<Student> students;
        public StudentRepository()
        {
            students = new List<Student>();
        }
        public int Count()
        {
            return students.Count;
        }
        public List<Student> Models()
        {
            return this.students;
        }
        public void AddModel(Student student)
        {
            this.students.Add(student);
        }
        public Student FindById(int id)
        {
            return this.students.FirstOrDefault(x => x.Id == id);
        }
        public Student FindByName(string name)
        {
            string[] names = name.Split(" ");
            string firstName = names[0];
            string lastName = names[1];
            return this.students.FirstOrDefault(x => x.FirstName == name && x.LastName == lastName);
        }
    }
}
