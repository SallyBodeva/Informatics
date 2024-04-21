public class Program
{
	static void Main()
	{
		List<string> input = Console.ReadLine().Split(" ").ToList();
		string shoreterWord = input[0];
		string longerWord = input[1];
		if (shoreterWord.Length != longerWord.Length)
		{
			longerWord = input.OrderByDescending(x => GetLonger(x).ToString()).FirstOrDefault();
			shoreterWord = input.OrderBy(x => GetLonger(x).ToString()).FirstOrDefault();
		}
		int sum = 0;
		for (int i = 0; i < shoreterWord.Length; i++)
		{
			sum += (int)shoreterWord[i] * (int)longerWord[i];
		}
		if (longerWord.Length > shoreterWord.Length)
		{
			for (int i = shoreterWord.Length; i < longerWord.Length; i++)
			{
				sum += (int)longerWord[i];
			}
		}
		Console.WriteLine(sum);
	}
	public static int GetLonger(string word1)
	{
		return word1.Length;
	}
}
