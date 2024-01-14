using System.Collections.Generic;
namespace P12_Worms_Holes
{
    public class Program
    {
        static void Main()
        {
            int[] worms = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] holes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> s = new Stack<int>(worms);
            Queue<int> q = new Queue<int>(holes);

            while (s.Count!=0 && q.Count!=0)
            {
                if (q.Peek()==s.Peek())
                {
                    s.Pop();
                    q.Dequeue();
                }
                else
                {
                    
                }
            }
        }
    }
}
