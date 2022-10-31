using System;


public class Program
{
    static void Main()
    {
        int badGrates = int.Parse(Console.ReadLine());
        double allGrades = 0;
        double badOnes = 0;
        int counter = 0;
        string lastProblem = null;
        while (true)
        {
            string cmd = Console.ReadLine();
            if (cmd == "Enough")
            {
                Console.WriteLine($"Average score: {allGrades / counter:f2}");
                Console.WriteLine($"Number of problems: {counter}");
                Console.WriteLine($"Last problem: {lastProblem}");
                break;
            }

            int grade = int.Parse(Console.ReadLine());
            if (grade <= 4.00)
            {
                badOnes++;
            }
            if (badGrates==badOnes)
            {
                Console.WriteLine($"You need a break, {badOnes} poor grades.");
                break;
            }
            counter++;
            allGrades += grade;
            lastProblem = cmd;
        }
    }
}

