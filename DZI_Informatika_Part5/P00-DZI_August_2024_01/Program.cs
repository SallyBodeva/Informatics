
public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> income = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        int longestPeriod = 1;
        for (int i = 0; i < income.Count-1; i++)
        {
            if (income[i+1] > income[i])
            {
                longestPeriod++;
            }
            else
            {
                longestPeriod = 1; 
            }
        }

        double lowestPercent = 0;
        int index = income.LastIndexOf(income.Min());
        if (index == income.Count-1)
        {
            lowestPercent = income[index] / (income[index-1]) * 100;
        }
        lowestPercent = (double)income[index] / (double)income[index+1] * 100;



       // Console.WriteLine($"Longest period with bigger profit is {longestPeriod} mounths.");
        Console.WriteLine($"Smaller with {lowestPercent:f2}%");
    }
}