public class Program
{
	public static void Main()
	{
		Menu();
		Action();
	}

	private static void Action()
	{
		int cmd = int.Parse(Console.ReadLine());
		List<string> list = Console.ReadLine().Split(" ").ToList();
		switch (cmd)
		{
			case 1:
				Console.WriteLine(string.Join(" ", AllVocals(list)));
				break;
			case 2:
				int n = int.Parse(Console.ReadLine());
				Console.WriteLine(string.Join(" ", WordsWithNLetters(list, n)));
				break;
			case 3:
				string target = Console.ReadLine();
				Console.WriteLine(string.Join(" ", PartOf(list, target)));
				break;
		}
	}

	private static void Menu()
	{
		Console.WriteLine("Choose option");
		Console.WriteLine("1 - All vocals");
		Console.WriteLine("2 - With N legth");
		Console.WriteLine("3 - Part Of");
	}

	public static List<string> AllVocals(List<string> words) 
	{
		List<string> result = new List<string>();
		foreach (var item in words)
		{
			if (item.Contains('a') && item.Contains('e') && item.Contains('i') && item.Contains('o') && item.Contains('u'))
			{
				result.Add(item);
			}
		}
		return result;
	}
	public static List<string> WordsWithNLetters(List<string> words, int n)
	{
		return words.Where(x => x.Length == n).ToList();
	}
	public static List<string> PartOf(List<string> words,string target)
	{
		List<string> result = new List<string>();
		foreach (var item in words)
		{
			if (item.Contains(target))
			{
				result.Add(target);
			}
		}
		return result;
	}
}