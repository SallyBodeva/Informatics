public class Program
{
    public static void Main()
    {
        List<int> elements = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        while (true)
        {
            string[] input = Console.ReadLine().Split(" ");
            string cmd = input[0];
            switch (cmd)
            {
                case "Delete":
                    int target = int.Parse(input[1]);
                    elements.RemoveAll(x => x == target);
                    break;
                case "Insert":
                    int element = int.Parse(input[1]);
                    int index = int.Parse(input[2]);
                    elements.Insert(index,element);
                    break;
                case "end":
                    Console.WriteLine(string.Join(" ",elements));
                    Environment.Exit(0);
                    break;
            }
        }
    }
}