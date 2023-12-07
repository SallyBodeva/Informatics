using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace P04_LessonsFinder
{
    public class Controller
    {
        private static Dictionary<string, Subject> subjects = new Dictionary<string, Subject>();
        public string AddSubject(List<string> args)
        {
            string subjectName = args[1];
            if (subjects.ContainsKey(subjectName))
            {
                return $"Subject already exists!";
            }
            Subject s = new Subject(subjectName);
            subjects.Add(subjectName, s);
            return $"Created Subject {subjectName}!";
        }

        public string AddLesson(List<string> args)
        {
            string subjectName = args[1];
            string title = args[2];
            int duration = int.Parse(args[3]);
            int grade = int.Parse(args[4]);
            int difficulty = int.Parse(args[5]);
            string teacher = args[6];
            string type = args[7];
            string secondParameter = args[8];
            Lesson l = null;
            switch (type)
            {
                case "online":
                    l = new OnlineLesson(title, duration, grade, difficulty, teacher, secondParameter);
                    break;
                case "lecture":
                    l = new LectureLesson(title, duration, grade, difficulty, teacher, secondParameter);
                    break;
            }
            subjects[subjectName].AddLesson(l);
            return $"Created Lesson {title} in Subject {subjectName}!";
        }
        public string RateLesson(List<string> args)
        {
            string subjectName = args[1];
            string title = args[2];
            int rate = int.Parse(args[3]);
            subjects[subjectName].AddRate(title, rate);
            return $"Rated {title} with {rate} rate";
        }


        public string GetAverageRating(List<string> args)
        {
            string subjectName = args[1];
            double avgRating= subjects[subjectName].AverageRating();
            return $"The average rating is: {avgRating:F2}";
        }

        public string GetLessonsByTeacher(List<string> args)
        {
            string subjectName = args[1];
            string teacher = args[2];
            StringBuilder sb = new StringBuilder();
            subjects[subjectName].GetLessonsByTeacher(teacher).ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString().TrimEnd();
        }

        public string GetLessonsBetweenDuration(List<string> args)
        {
            string subjectName = args[1];
            int from = int.Parse(args[2]);
            int to = int.Parse(args[3]);
            StringBuilder sb = new StringBuilder();
            subjects[subjectName].GetLessonsBetweenDuration(from,to).ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString().TrimEnd();
        }

    }
}
