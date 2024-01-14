using System;
using System.Collections.Generic;
using System.Linq;

namespace P12_Worms_Holes
{
    public class Program
    {
        static void Main()
        {
            int[] worms = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] holes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> wormStack = new Stack<int>(worms);
            Queue<int> holeQueue = new Queue<int>(holes);
            int matches = 0;

            while (wormStack.Count != 0 && holeQueue.Count != 0)
            {
                if (holeQueue.Peek() == wormStack.Peek())
                {
                    wormStack.Pop();
                    holeQueue.Dequeue();
                    matches++;
                }
                else
                {
                    holeQueue.Dequeue();
                    int lastWorm = wormStack.Pop();
                    if ((lastWorm -= 3) > 0)
                    {
                        wormStack.Push(lastWorm);
                    }
                }
            }

            Console.WriteLine(matches > 0 ? $"Matches: {matches}" : "There are no matches.");

            if (wormStack.Count == 0)
            {
                Console.WriteLine(matches == holes.Length ? "Every worm found a suitable hole!" : "Worms left: none");
            }
            else
            {
                Console.WriteLine($"Worms left: {string.Join(", ", wormStack)}");
            }

            Console.WriteLine(holeQueue.Count == 0 ? "Holes left: none" : $"Holes left: {string.Join(", ", holeQueue)}");
        }
    }
}
