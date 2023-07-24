using System;
using System.Collections.Generic;
using System.Text;

namespace P03_UniversityCompetition
{
    public class Student
    {
        private int id;
        private string firstName;
        private string lastName;
        private List<int> coveredExams;

        public Student(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public int Id
        {
            get => id;
            private set
            {
                id = value;
            }
        }
        public string FirstName
        {
            get { return firstName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or white space!");
                }
                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or white space!");
                }
                lastName = value;
            }
        }
        public List<int> CoveredExams { get => coveredExams; set => coveredExams = value; }
        public University University  { get; set; }

        public void CoverExam(Subject subject)
        {
            this.CoveredExams.Add(subject.Id);
        }
        public void JoinUniversity(University university)
        {
            this.University = university;
        }
    }
}
