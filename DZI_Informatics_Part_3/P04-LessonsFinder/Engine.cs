using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04_LessonsFinder
{
    public class Engine
    {
        private static Controller controller;

        public Engine()
        {
            controller = new Controller();
            Run();
        }

        private static void Run()
        {
            while (true)
            {
                List<string> args = Console.ReadLine().Split(' ').ToList();
                string result = string.Empty;
                try
                {
                    switch (args[0])
                    {
                        case "AddSubject":
                            result = controller.AddSubject(args);
                            break;
                        case "AddLesson":
                            result = controller.AddLesson(args);
                            break;
                        case "RateLesson":
                            result = controller.RateLesson(args);
                            break;
                        case "GetAverageRating":
                            result = controller.GetAverageRating(args);
                            break;
                        case "GetLessonsByTeacher":
                            result = controller.GetLessonsByTeacher(args);
                            break;
                        case "GetLessonsBetweenDuration":
                            result = controller.GetLessonsByTeacher(args);
                            break;
                        case "End":
                            Environment.Exit(0);
                            break;
                    }
                   
                }
                catch (Exception ex)
                {
                    result = ex.Message;
                }
                Console.WriteLine(result);
            }
        }
    }
}
