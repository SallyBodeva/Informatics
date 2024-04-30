public class Program
{
    public static void Main()
    {
        string path = Console.ReadLine();
        string[] text = File.ReadAllLines(path);

        HashSet<string> validEmails = new HashSet<string>();

        for (int i = 0; i < text.Length; i++)
        {
            foreach (var item in text[i].Split(" "))
            {
                if (item.Contains("@") && (item.EndsWith(".com") || item.EndsWith(".org")))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}