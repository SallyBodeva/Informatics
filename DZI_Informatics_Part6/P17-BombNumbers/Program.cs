public class Program
{
    public static void Main()
    {
        List<int> elements = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        int[] bomb = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int indexTarget = elements.IndexOf(elements.FirstOrDefault(x => x == bomb[0]));
        try
        {
            for (int i = 1; i <= bomb[1]; i++)
            {
                elements.RemoveAt(indexTarget - 1);
                elements.RemoveAt(indexTarget + 1);
                indexTarget = elements.IndexOf(elements.FirstOrDefault(x => x == bomb[0]));
            }
            elements.Remove(elements.FirstOrDefault(x => x == bomb[0]));
        }
        catch (Exception)
        {

        }
        finally
        {
            Console.WriteLine(string.Join(" ",elements));
            Console.WriteLine(elements.Sum());
        }

    }
}
