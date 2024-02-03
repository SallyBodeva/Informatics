namespace P05_LongestWord
{
    public class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(" ");
            int maxWordLength = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length>maxWordLength)
                {
                    maxWordLength = words[i].Length;
                }
            }
            Console.WriteLine(maxWordLength);
        }
    }
}
