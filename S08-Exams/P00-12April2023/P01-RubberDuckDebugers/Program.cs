using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

public class Program
{
    private const string DarthVaderDucky = "(0-60)";
    private const string ThorDucky = "(61-120)";
    private const string BigBlueRubberDucky = "(121-180)";
    private const string SmallYellowRubberDucky = "(181-240)";

    static void Main()
    {
        Queue<int> timeNeeded = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
        Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
        int DarthVaderDuckyCount = 0;
        int ThorDuckyCount = 0;
        int BigBlueRubberDuckyCount = 0;
        int SmallYellowRubberDuckyCount = 0;
        while (timeNeeded.Count!=0 && tasks.Count!=0)
        {
            int firstTime = timeNeeded.Dequeue();
            int lastTask = tasks.Pop();
            int calculatedValue = firstTime * lastTask;
            if (calculatedValue > 0 && calculatedValue <= 60)
            {
                DarthVaderDuckyCount++;
            }
            else if (calculatedValue > 60 && calculatedValue <= 120)
            {
                ThorDuckyCount++;
            }
            else if (calculatedValue > 120 && calculatedValue <= 180)
            {
                BigBlueRubberDuckyCount++;
            }
            else if (calculatedValue > 180 && calculatedValue <= 240)
            {
                SmallYellowRubberDuckyCount++;
            }
            else
            {
                timeNeeded.Enqueue(firstTime);
                tasks.Push(lastTask - 2);
            }
        }
        Console.WriteLine($"Congratulations, all tasks have been completed! Rubber ducks rewarded:");
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Darth Vader Ducky: {DarthVaderDuckyCount}");
        sb.AppendLine($"Thor Ducky: {ThorDuckyCount}");
        sb.AppendLine($"Big Blue Rubber Ducky: {BigBlueRubberDuckyCount}");
        sb.AppendLine($"Small Yellow Rubber Ducky: {SmallYellowRubberDuckyCount}");
        Console.WriteLine(sb.ToString().TrimEnd());
    }
}

