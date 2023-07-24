using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03_UniversityCompetition
{
    public class Controller
    {
        private SubjectRepository subjects;
        private StudentRepository students;
        private UniversityRepository universities;
        public Controller()
        {
            subjects = new SubjectRepository();
            students = new StudentRepository();
            universities = new UniversityRepository();
        }
        public string AddSubject(string subjectName, string subjectType)
        {
            if (subjectType != nameof(EconomicalSubject) && subjectType != nameof(HumanitySubject) && subjectType != nameof(TechnicalSubject))
            {
                return $"Subject type {subjectType} is not available in the application!";
            }
            Subject s = this.subjects.FindByName(subjectName);
            if (s != null)
            {
                return $"{subjectName} is already added in the repository.";
            }
            else
            {
                int id = subjects.Count() + 1;
                switch (subjectType)
                {
                    case nameof(EconomicalSubject):
                        s = new EconomicalSubject(id, subjectName);
                        break;
                    case nameof(TechnicalSubject):
                        s = new TechnicalSubject(id, subjectName);
                        break;
                    case nameof(HumanitySubject):
                        s = new HumanitySubject(id, subjectName);
                        break;
                }
                subjects.AddModel(s);
                return $"{subjectType} {subjectName} is created and added to the {nameof(SubjectRepository)}!";
            }
        }
        public string AddUniversity(string universityName, string category, int capacity, List<int> requiredSubjects)
        {
            var u = this.universities.FindByName(universityName);
            if (u != null)
            {
                return $"{universityName} is already added in the repository.";
            }
            else
            {
                int id = universities.Count() + 1;
                u = new University(id, universityName, category, capacity, requiredSubjects);
                universities.AddModel(u);
                return $"{universityName} university is created and added to the {nameof(UniversityRepository)}!";
            }
        }
        public string AddStudent(string firstName, string lastName)
        {
            string n = firstName + " " + lastName;
            var s = this.students.FindByName(n);
            if (s != null)
            {
                return $"{firstName} {lastName} is already added in the repository.";
            }
            else
            {
                int id = this.students.Count() + 1;
                s = new Student(id, firstName, lastName);
                return $"Student {firstName} {lastName} is added to the {nameof(StudentRepository)}!";
            }
        }
        public string TakeExam(int studentId, int subjectId)
        {
            var student = this.students.FindById(studentId);
            var subject = this.subjects.FindById(subjectId);
            if (student == null)
            {
                return "Invalid student ID!";
            }
            if (subject == null)
            {
                return "Invalid subject ID!";
            }
            if (student.CoveredExams.Contains(subjectId))
            {
                return $"{student.FirstName} {student.LastName} has already covered exam of {subject.Name}.";
            }
            else
            {
                student.CoveredExams.Add(subjectId);
                return $"{student.FirstName} {student.LastName} covered {subject.Name} exam!";
            }
        }
        public string ApplyToUniversity(string studentName, string universityName)
        {
            string[] n = studentName.Split(' ');
            string firstName = n[0];
            string lastName = n[1];
            var s = this.students.FindByName(studentName);
            var u = this.universities.FindByName(universityName);
            if (s == null)
            {
                return $"{firstName} {lastName} is not registered in the application!";
            }
            if (u == null)
            {
                return $"{universityName} is not registered in the application!";
            }
            if (!s.CoveredExams.SequenceEqual(u.RequiredSubjects))
            {
                return $"{studentName} has not covered all the required exams for {universityName} university!";
            }
            if (s.University.Name == u.Name)
            {
                return $"{firstName} {lastName} has already joined {universityName}.";
            }
            else
            {
                s.JoinUniversity(u);
                return $"{firstName} {lastName} joined {universityName} university!";
            }
        }
        public string UniversityReport(int universityId)
        {
            StringBuilder sb = new StringBuilder();
            var u = universities.FindById(universityId);
            sb.AppendLine($"*** {u.Name} ***");
            sb.AppendLine($"Profile: {u.Category}");
            sb.AppendLine($"Students admitted: {students.Models().Where(s => s.University == u).Count()}");
            sb.AppendLine($"University vacancy: {u.Capacity - students.Models().Where(s => s.University == u).Count()}");
            return sb.ToString().TrimEnd();
        }
    }
}
