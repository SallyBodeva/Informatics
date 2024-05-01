public class Program
{
    static void Main()
    {
    }

    private static void BiggestSequence()
    {
        int[] elements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int[] sequence = elements.Where(x => x == elements[0]).ToArray();
        for (int i = 1; i < elements.Length; i++)
        {
            int[] currentSequence = elements.Where(x => x == elements[i]).ToArray();
            if (currentSequence.Length > sequence.Length)
            {
                sequence = currentSequence;
            }
        }
        Console.WriteLine(string.Join(" ", sequence));
    }

    private static void LeftAndRightSum()
    {
        int[] elements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        bool isInvalid = false;
        for (int i = 0; i < elements.Length; i++)
        {
            int[] leftElememts = elements.Take(i).ToArray();
            int[] rightElememts = elements.Skip(i + 1).ToArray();
            if (leftElememts.Sum() == rightElememts.Sum())
            {
                Console.WriteLine(i);
                isInvalid = true;
            }
        }
        if (!isInvalid) { Console.WriteLine("no"); }
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
