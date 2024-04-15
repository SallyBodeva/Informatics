public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> nums = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            nums.Add(i);
            Console.WriteLine(string.Join(" ", nums));
        }
        for (int i = n; i >=1; i--)
        {
            nums.RemoveAt(nums.Count - 1);
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
