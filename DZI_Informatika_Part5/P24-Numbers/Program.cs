public class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

        double avg = numbers.Average();
        numbers = numbers.Where(x => x > avg).OrderByDescending(x=>x).Take(5).ToList();
        if (numbers.Any())
        {
            Console.WriteLine(string.Join(" ", numbers));   
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
