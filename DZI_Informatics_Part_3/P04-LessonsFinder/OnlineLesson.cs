using System;
using System.Collections.Generic;
using System.Text;

namespace P04_LessonsFinder
{
    public class OnlineLesson : Lesson
    {
        private string platform;

        public OnlineLesson(string title, int duration, int grade, int difficulty, string teacher,string platform) : base(title, duration, grade, difficulty, teacher)
        {
            this.Platform = platform;
        }
        public string Platform
        {
            get { return platform; }
            set
            {
                if (value.Length<3 || value.Length>30)
                {
                    throw new ArgumentException("Platform should be between 3 and 30 characters!");
                }
                platform = value;
            }
        }
        public override string ToString()
        {
            return base.ToString()+ $" @ Online: {Platform}"; 
        }
    }
}
