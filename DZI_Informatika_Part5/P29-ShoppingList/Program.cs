public class Program
{
	static void Main()
	{
		List<string> groceries = Console.ReadLine().Split("!").ToList();

		while (true)
		{
			string[] input = Console.ReadLine().Split(" ");
			string end = string.Join(" ", input);
			if (end == "Go Shopping!")
			{
				Console.WriteLine(string.Join(", ", groceries));
				Environment.Exit(0);

			}
			string cmd = input[0];
			switch (cmd)
			{
				case "Urgent":
					string item = input[1];
					if (!groceries.Contains(item))
					{
						groceries.Insert(0, item);
					}
					break;
				case "Unnecessary":
					item = input[1];
					if (groceries.Contains(item))
					{
						groceries.Remove(item);
					}
					break;
				case "Correct":
					string oldName = input[1];
					if (groceries.Contains(oldName))
					{
						string newName = input[2];
						int index = groceries.IndexOf(oldName);
						groceries.RemoveAt(index);
						groceries.Insert(index, newName);
					}
					break;
				case "Rearrange":
					item = input[1];
					if (groceries.Contains(item))
					{
						int index = groceries.IndexOf(item);
						groceries.RemoveAt(index);
						groceries.Add(item);
					}
					break;
			}
		}
	}
}