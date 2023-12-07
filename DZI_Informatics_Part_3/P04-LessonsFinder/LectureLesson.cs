using System;
using System.Collections.Generic;
using System.Text;

namespace P04_LessonsFinder
{
    public class LectureLesson:Lesson
    {
        public LectureLesson(string title, int duration, int grade, int difficulty, string teacher,string location) : base(title, duration, grade, difficulty, teacher)
        {
            this.Location = location;
        }

        public string Location { get; set; }

        public override string ToString()
        {
            return base.ToString()+ $" @ Onsite: {Location}";
        }
    }
}
