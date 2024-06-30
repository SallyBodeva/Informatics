using System.Linq;

public class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
        Console.WriteLine(string.Join(", ", nums.Where(x => x % 2 == 0).OrderBy(x=>x)));
    }
}
