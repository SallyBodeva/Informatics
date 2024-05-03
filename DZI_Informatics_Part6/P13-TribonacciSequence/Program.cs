public class Program
{
    static void Main()
    {
        List<int> sequence = new List<int>();
        int n = int.Parse(Console.ReadLine());
        int initialNum = 1;
        for (int i = 0; i < n; i++)
        {
            sequence.Add(initialNum);
            initialNum = sequence.TakeLast(3).Sum();
        }
        Console.WriteLine(string.Join(" ",sequence));
    }
}

