public class Program
{
	public static void Main()
	{
		List<int> houses = Console.ReadLine().Split("@").Select(int.Parse).ToList();
		int cupidIndex = 0;
		while (true)
		{
			string[] commands = Console.ReadLine().Split(" ");
			if (commands[0]== "Love!")
			{
                Console.WriteLine($"Cupid's last position was {cupidIndex}.");
				if (houses.All(x=>x==0))
				{
                    Console.WriteLine($"Mission was successful.");
                }
				else
				{
                    Console.WriteLine($"Cupid has failed {houses.Where(x=>x>0).Count()} places.");
                }
                Environment.Exit(0);
			}
			int length = int.Parse(commands[1]);
			cupidIndex += length;
			if (cupidIndex>=houses.Count)
			{
				cupidIndex = 0;
			}
			if (houses[cupidIndex]==0)
			{
                Console.WriteLine($"Place {cupidIndex} already had Valentine's day.");
				continue;
            }
			houses[cupidIndex] -= 2;
			if (houses[cupidIndex] ==0)
			{
                Console.WriteLine($"Place {cupidIndex} has Valentine's day.");
            }
		}
	}
}