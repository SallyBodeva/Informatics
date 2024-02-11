namespace P12_PeaksAndBottmsInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int peaksCount = 0;
            int bottomsCount = 0;
            for (int i = 1; i < numbers.Length-1; i++)
            {
                if (numbers[i] > numbers[i-1] && numbers[i] > numbers[i+1])
                {
                    peaksCount++;
                }
                if (numbers[i] < numbers[i - 1] && numbers[i] < numbers[i + 1])
                {
                    bottomsCount++;
                }
            }
            Console.WriteLine($"{peaksCount} {bottomsCount}");
        }
    }
}
