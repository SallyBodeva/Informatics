using System;


public class Program
{
    static void Main()
    {
        double steps = 0;
        while (true)
        {
            string stepsWaliking = Console.ReadLine();
            if (stepsWaliking == "Going home")
            {
                double homeStpes = double.Parse(Console.ReadLine());
                steps += homeStpes;
                if (steps<10000)
                {
                    Console.WriteLine($"{10000-steps} more steps to reach goal.");
                    break;
                }
            }
            else
            {
                steps += double.Parse(stepsWaliking);
            }
            if (steps>=10000)
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{steps-10000} steps over the goal!");
                break;
            }
            
        }
    }
}

