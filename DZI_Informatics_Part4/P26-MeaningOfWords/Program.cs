using System.Text;

namespace P26_MeaningOfWords
{
    internal class Program
    {
       private static  Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
        static void Main(string[] args)
        {

            AddWords();
            Console.WriteLine(Statistics());
        }
        public static void AddWords()
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split(" => ");
                if (input[0] == "stop")
                {
                    break;
                }
                if (words.ContainsKey(input[0]))
                {
                    List<string> newMeanings = input[1].Split(",").ToList();
                    words[input[0]].AddRange(newMeanings);
                }
                else
                {
                    words.Add(input[0], input[1].Split(",").ToList());
                }
            }
        }
        public static string Statistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Words count {words.Count}");
            sb.AppendLine($"Words with only one meaning: {string.Join(" ", words.Values.Where(x => x.Count == 1).ToList())}");
            string wordWithMostMeanings = words.OrderByDescending(x => x.Value.Count).FirstOrDefault().Key;
            int wordWithMostMeaningsCount = words.OrderByDescending(x => x.Value.Count).FirstOrDefault().Value.Count;
            sb.AppendLine($"Word {wordWithMostMeanings} has {wordWithMostMeaningsCount} meanings");
            return sb.ToString().TrimEnd();

        }
    }
}
