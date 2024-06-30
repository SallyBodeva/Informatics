public class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(" ");
        if (input.Length != 0)
        {
            Console.WriteLine(string.Join("\n", input.Where(x => char.IsUpper(x[0]))));
        }
    }
}
