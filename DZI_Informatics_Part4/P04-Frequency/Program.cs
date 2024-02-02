namespace P04_Frequency
{
    internal class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(" ");
            Dictionary<string, int> frequency = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (frequency.ContainsKey(words[i]))
                {
                    frequency[words[i]]++;
                }
                else
                {
                    frequency.Add(words[i], 1);
                }
            }
            foreach (var item in frequency)
            {
                Console.Write($"{item.Key} {item.Value}; ");
            }
        }
    }
}
