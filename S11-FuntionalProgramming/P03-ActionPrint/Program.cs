public class Program
{
    static void Main()
    {
        string[] names = Console.ReadLine().Split(" ");

        Action<string[]> print = (array) => Console.WriteLine(string.Join("\n", array));

        print(names);
    }
}
