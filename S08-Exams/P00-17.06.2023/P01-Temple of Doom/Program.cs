using System.Collections.Generic;
using System;
using System.Linq;

namespace TempleOfDoom
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<int> tools = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());

            Stack<int> substances = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());

            List<int> challenges = new List<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToList());

            while (true)
            {
                int tool = tools.Peek();
                int substance = substances.Peek();

                if (challenges.Contains(tool * substance))
                {
                    challenges.Remove(tool * substance);
                    tools.Dequeue();
                    substances.Pop();

                    if (challenges.Count == 0)
                    {
                        Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
                        break;
                    }

                }
                else
                {
                    tools.Enqueue(tools.Dequeue() + 1);
                    substances.Push(substances.Pop() - 1);

                    if (substances.Peek() == 0)
                    {
                        substances.Pop();
                    }

                    if (substances.Count == 0)
                    {
                        Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
                        break;
                    }
                }
            }
            if (tools.Count != 0)
            {
                Console.WriteLine($"Tools: {string.Join(", ", tools)}");
            }
            if (substances.Count != 0)
            {
                Console.WriteLine($"Substances: {string.Join(", ", substances)}");
            }
            if (challenges.Count != 0)
            {
                Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
            }
        }
    }
}