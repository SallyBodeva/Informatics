public class Program
{
    static void Main()
    {
        TopIntegers();
    }

    private static void TopIntegers()
    {
        int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        for (int i = 0; i < array.Length; i++)
        {
            int count = 0;
            int[] rigthElements = array.Skip(i + 1).ToArray();
            foreach (var item in rigthElements)
            {
                if (array[i] > item)
                {
                    count++;
                }
            }
            if (count == rigthElements.Length)
            {
                Console.Write(array[i] + " ");
            }
        }
    }

    private static void GetSimilarElements()
    {
        string[] firstArray = Console.ReadLine().Split(" ");
        string[] secondArray = Console.ReadLine().Split(" ");

        string[] similarities = secondArray.Where(x => firstArray.Contains(x)).ToArray();

        Console.WriteLine(string.Join(" ", similarities));
    }
}
