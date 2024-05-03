public class Program
{
    static void Main()
    {
        List<int> wagons = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        int capacity = int.Parse(Console.ReadLine());
        while (true)
        {
            string[] info = Console.ReadLine().Split(" ");
            string cmd = info[0];
            switch (cmd)
            {
                case "Add":
                    wagons.Add(int.Parse(info[1]));
                    break;
                case "end":
                    Console.WriteLine(string.Join(" ",wagons));
                    Environment.Exit(0);
                    break;
                default:
                    int people = int.Parse(cmd);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i]+people<=capacity)
                        {
                            wagons[i] += people;
                        }
                    }
                    break;
            }
        }
    }
}
