using System.Runtime.CompilerServices;

namespace P20_ListOperations
{
    public class Program
    {
        static void Main()
        {
            Train();
        }

        private static void Train()
        {
            List<int> wagons = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int maxPassengers = int.Parse(Console.ReadLine());
            string[] cmd;
            while (true)
            {
                cmd = Console.ReadLine().Split(" ");
                if (cmd[0] == "end")
                {
                    break;
                }
                if (cmd[0] == "Add")
                {
                    wagons.Add(int.Parse(cmd[1]));
                }
                else
                {
                    int passengers = int.Parse(cmd[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxPassengers)
                        {
                            wagons[i] += passengers;
                        }
                        else
                        {
                            wagons[i] += maxPassengers - wagons[i];
                            passengers-= maxPassengers - wagons[i];
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}
