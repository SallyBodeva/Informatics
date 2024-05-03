public class Program
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        while (true)
        {
            string[] input = Console.ReadLine().Split(" ");
            string cmd = input[0];
            switch (cmd)
            {
                case "Contains":
                    int number = int.Parse(input[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    break;
                case "PrintEven":
                    Console.WriteLine(string.Join(" ",numbers.Where(x=>x%2==0).ToArray()));
                    break;
                case "PrintOdd":
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 1).ToArray()));
                    break;
                case "GetSum":
                    Console.WriteLine(numbers.Sum());
                    break;
                case "Filter":
                    string mathFunction = input[1];
                    number = int.Parse(input[2]);
                    List<int> filteredList = new List<int>();
                    switch (mathFunction)
                    {
                        case "<":
                            filteredList = numbers.Where(x => x < number).ToList();
                            break;
                        case "<=":
                            filteredList = numbers.Where(x => x <= number).ToList();
                            break;
                        case ">":
                            filteredList = numbers.Where(x => x > number).ToList();
                            break;
                        case ">=":
                            filteredList = numbers.Where(x => x >= number).ToList();
                            break;
                    }
                    Console.WriteLine(string.Join(" ",filteredList));
                    break;
                case "end":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}

