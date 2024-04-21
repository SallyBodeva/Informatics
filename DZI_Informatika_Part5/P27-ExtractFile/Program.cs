public class Program
{
	public static void Main()
	{
		List<string> usernames = Console.ReadLine().Split(", ").ToList();
		
		foreach (var item in usernames)
		{
			if (item.Length > 3 && item.Length < 16)
			{
				if (IsValid(item))
				{
                    Console.WriteLine(item);
                }
			}
		}
	}
	public static bool IsValid(string word)
	{
		foreach (char c in word)
		{
			if (!(char.IsLetterOrDigit(c) || c == '-' || c == '_'))
			{
				return false;
			}
		}
		return true;
	}
}