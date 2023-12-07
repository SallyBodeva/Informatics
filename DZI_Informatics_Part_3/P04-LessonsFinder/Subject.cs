using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04_LessonsFinder
{
    public class Subject
    {
        private List<Lesson> lessons;
        private string name;

        public Subject(string name)
        {
            this.Name = name;
            lessons = new List<Lesson>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length<2 || value.Length>40)
                {
                    throw new ArgumentException("Name should be between 2 and 40 characters!");
                }
                name = value;
            }
        }
        public void AddLesson(Lesson lesson)
        {
            this.lessons.Add(lesson);
        }
        public void AddRate(string title, int rate)
        {
            Lesson l = this.lessons.FirstOrDefault(x => x.Title == title);
            if (l==null)
            {
                throw new ArgumentException("Lesson not found!");
            }
            l.AddRating(rate);
        }
        public double AverageRating()
        {
            return this.lessons.Where(x=>x.Ratings.Count>0).Average(x => x.Rating);
        }
        public List<Lesson> GetLessonsByTeacher(string teacher)
        {
            List<Lesson> l = this.lessons.Where(x => x.Teacher == teacher).OrderByDescending(x => x.Duration).ToList();
            return l;
        }
        public List<Lesson> GetLessonsBetweenDuration(int from, int to)
        {
            int d = to - from;
            List<Lesson> l = this.lessons.Where(x => x.Duration == d).OrderByDescending(x=>x.Rating).ToList();
            return l;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Subject {Name}");
            sb.AppendLine($"Total Lessons: {this.lessons.Count}");
            return sb.ToString().TrimEnd();
        }
    }
}


