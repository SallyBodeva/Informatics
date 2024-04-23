public class Program
{
	public static void Main()
	{
		List<int> targets = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
		int shootTargetsCount = 0;
		while (true)
		{
			string cmd = Console.ReadLine();
			if (cmd=="End")
			{
                Console.WriteLine($"Shot targets: {shootTargetsCount} -> {string.Join(" ",targets)}");
                Environment.Exit(0);
			}
			int index = int.Parse(cmd);
			if (index>=0 && index<targets.Count  && targets[index]!=-1)
			{
				int initialValue = targets[index];
				targets[index] = -1;
				shootTargetsCount++;
				for (int i = 0; i < targets.Count; i++)
				{
					if (targets[i] > initialValue && targets[i] != -1)
					{
						targets[i] -= initialValue;
					}
					else if (targets[i] <= initialValue && targets[i] != -1)
					{
						targets[i] += initialValue;
					}
				}
			}
		}
	}
}