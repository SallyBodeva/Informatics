using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04_LessonsFinder
{
    public abstract class Lesson
    {
        private readonly double rating;
        private string title;
        private int duration;
        private int grade;
        private int difficulty;
        private string teacher;

        protected Lesson(string title, int duration, int grade, int difficulty, string teacher)
        {
            this.Title = title;
            this.Duration = duration;
            this.Grade = grade;
            this.Difficulty = difficulty;
            this.Teacher = teacher;
            this.Ratings= new List<int>();
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length < 3 || value.Length > 54)
                {
                    throw new ArgumentException("Title should be between 3 and 54 characters!");
                }
                title = value;
            }
        }

        public int Duration
        {
            get { return duration; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Duration should be positive!");
                }
                duration = value;
            }
        }

        public int Grade
        {
            get { return grade; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Grade should be between 1 and 12!");
                }
                grade = value;
            }
        }

        public int Difficulty
        {
            get { return difficulty; }
            set
            {
                if (value < 1 || value > 3)
                {
                    throw new ArgumentException("Difficulty should be between 1 and 3!");
                }
                difficulty = value;
            }
        }

        public string Teacher
        {
            get { return teacher; }
            set
            {
                if (value.Length < 3 || value.Length > 54)
                {
                    throw new ArgumentException("Teacher should be between 3 and 54 characters!");
                }
                teacher = value;
            }
        }

        public List<int> Ratings { get; set; }
        public double Rating
        {
            get
            {
                if (this.Ratings.Count>0)
                {
                    return this.Ratings.Average();
                }
                return 0;
            }
        }

        public void AddRating(int rate)
        {
            this.Ratings.Add(rate);
        }

        public override string ToString()
        {
            return $"Title: {Title} for {Grade} grade ({Duration} mins.) - difficulty {Difficulty} by {Teacher} (Rating: {Rating} / 5)";
        }
    }
}
