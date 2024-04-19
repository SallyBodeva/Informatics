public class Program
{
    public static void Main()
    {
        List<int> targets = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        while (true)
        {
            string[] input = Console.ReadLine().Split(" ");
            switch (input[0])
            {
                case "Shoot":
                    int index = int.Parse(input[1]);
                    int power = int.Parse(input[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= power;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                    break;
                case "Add":
                    index = int.Parse(input[1]);
                    int value = int.Parse(input[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                    break;
                case "Strike":
                    index = int.Parse(input[1]);
                    int radius = int.Parse(input[2]);
                    if (index >= 0 && index < targets.Count && index - radius >= 0 && index - radius < targets.Count)
                    {
                        targets.RemoveAt(index);
                        for (int i = 0; i < radius; i++)
                        {
                            targets.RemoveAt(index - 1);
                            targets.RemoveAt(index + 1);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                    break;
                case "End":
                    Console.WriteLine(string.Join("|",targets));
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
