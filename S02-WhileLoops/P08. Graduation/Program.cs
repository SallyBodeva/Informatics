using System;


public class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        int klas = 0;
        int failure = 0;
        double grades = 0;
        while (klas!=12)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade>=4.00)
            {
                klas++;
                grades+=grade;
            }
            else
            {
                failure++;
                klas++;
            }
            if (failure==2)
            {
                Console.WriteLine($"{name} has been excluded at {klas-1} grade");
                break;
            }
        }
        if (klas == 12)
        {
           Console.WriteLine($"{name} graduated. Average grade: {(grades / 12):f2}");
        }
    }
}

