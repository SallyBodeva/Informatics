using P18_UniversityCompetition_OOP_.Models;
using P18_UniversityCompetition_OOP_.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Core.Contracts;

namespace P18_UniversityCompetition_OOP_.Core
{
    public class Controller : IController
    {
        private StudentRepository students;
        private SubjectRepository subjects;
        private UniversityRepository universities;
        public string AddStudent(string firstName, string lastName)
        {
            string fullName = firstName + ' ' + lastName;
            if (students.FindByName(fullName)!=null)
            {
                return $"{firstName} {lastName} is already added in the repository.";
            }
            Student s = new Student(students.Models.Count-1, firstName, lastName);
            students.AddModel(s);
            return $"Student {firstName} {lastName} is added to the {nameof(StudentRepository)}!";
        }

        public string AddSubject(string subjectName, string subjectType)
        {
            if (subjects.FindByName(subjectName)!=null)
            {
                return $"{subjectName} is already added in the repository.";
            }
            Subject s = null;
            switch (subjectType)
            {
                case nameof(EconomicalSubject):
                    s = new EconomicalSubject(subjects.Models.Count - 1, subjectName);
                    break;
                case nameof(TechnicalSubject):
                    s = new TechnicalSubject(subjects.Models.Count - 1, subjectName);
                    break;
                case nameof(HumanitySubject):
                    s = new HumanitySubject(subjects.Models.Count - 1, subjectName);
                    break;
                default:
                    return $"Subject type {subjectType} is not available in the application!";
                    break;
            }
            this.subjects.AddModel(s);
            return $"{subjectType} {subjectName} is created and added to the {nameof(SubjectRepository)}!";
        }

        public string AddUniversity(string universityName, string category, int capacity, List<string> requiredSubjects)
        {
            if (universities.FindByName(universityName)!=null)
            {
                return $"{universityName} is already added in the repository.";
            }
            List<int> requiredSubjectsId = new List<int>();
            foreach (var sub in requiredSubjects)
            {
                int id = subjects.FindByName(sub).Id;
                requiredSubjectsId.Add(id);
            }
            University u = new University(universities.Models.Count - 1, universityName, category, capacity,requiredSubjectsId);
            universities.AddModel(u);
            return $"{universityName} university is created and added to the {nameof(UniversityRepository)}!";
        }

        public string ApplyToUniversity(string studentName, string universityName)
        {
            string[] fullName = studentName.Split(" ");
            string firstName = fullName[0];
            string lastName = fullName[1];
            Student s = students.FindByName(studentName);
            University u = universities.FindByName(universityName);
            bool isAccepted = true;
            if (s == null)
            {
                return $"{firstName} {lastName} is not registered in the application!";
            }
            if (u==null)
            {
                return $"{universityName} is not registered in the application!";
            }
            foreach (var exam in u.RequiredSubjects)
            {
                if (!s.CoveredExams.Contains(exam))
                {
                    isAccepted = false;
                }
            }
            if (isAccepted==false)
            {
                return $"{studentName} has not covered all the required exams for {universityName} university!";
            }
            if (s.University==u)
            {
                return $"{firstName} {lastName} has already joined {universityName}.";
            }
            s.JoinUniversity(u);
            return $"{firstName} {lastName} joined {universityName} university!";
        }

        public string TakeExam(int studentId, int subjectId)
        {
            Student s = students.FindById(studentId);
            Subject sub = subjects.FindById(subjectId);
            if (s==null)
            {
                return $"Invalid student ID!";
            }
            if (sub==null)
            {
                return "Invalid subject ID!";
            }
            if (students.FindById(studentId).CoveredExams.Contains(subjectId))
            {
                return $"{s.FirstName} {s.LastName} has already covered exam of {sub.Name}.";
            }
            s.CoverExam(sub);
            return $"{s.FirstName} {s.LastName} covered {sub.Name} exam!";
        }

        public string UniversityReport(int universityId)
        {
            University u = universities.FindById(universityId);
            int studentsCount = students.Models.Where(x => x.University == u).Count();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"*** {u.Name} ***");
            sb.AppendLine($"Profile: {u.Category}");
            sb.AppendLine($"Students admitted: {studentsCount}");
            sb.AppendLine($"University vacancy: {u.Capacity-studentsCount}");

            return sb.ToString().TrimEnd();
        }
    }
}
