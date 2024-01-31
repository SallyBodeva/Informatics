namespace P02_DifferenceOfAbsValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                nums.Add(num);
            }
            int minDiff = int.MinValue;
            Console.WriteLine(string.Join(" ", nums));
            List<int> orderedNums = nums.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(" ", orderedNums));
            for (int i = 0; i < orderedNums.Count - 1; i++)
            {
                if (minDiff < (orderedNums[i] - orderedNums[i + 1]))
                {
                    minDiff = orderedNums[i] - orderedNums[i + 1];
                }
            }
            Console.WriteLine(Math.Abs(minDiff));
        }
    }
}
