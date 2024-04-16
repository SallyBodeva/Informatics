using System.Data.SqlTypes;

public class Program
{
    public static void Main()
    {
        string initialUserName = Console.ReadLine();
        while (true)
        {
            string[] input = Console.ReadLine().Split(" ");
            if (input[0] == "Registration")
            {
                break;
            }
            string command = input[0];
            switch (command)
            {
                case "Letters":
                    string type = input[1];
                    if (type == "Lower") { initialUserName = initialUserName.ToLower(); }
                    else { initialUserName = initialUserName.ToUpper(); }
                    Console.WriteLine(initialUserName);
                    break;
                case "Reverse":
                    int startIndex = int.Parse(input[1]);
                    int endIndex = int.Parse(input[2]);
                    if (startIndex >= 0 && endIndex < initialUserName.Length && startIndex <= endIndex)
                    {
                        string substring = initialUserName.Substring(startIndex, endIndex - startIndex + 1);
                        string reversed = new string(substring.Reverse().ToArray());
                        Console.WriteLine(reversed);
                    }
                    break;
                case "Substring":
                    string substring2 = input[1];
                    if (initialUserName.Contains(substring2))
                    {
                        int index = initialUserName.IndexOf(substring2);
                        initialUserName = initialUserName.Remove(index, substring2.Length);
                        Console.WriteLine(initialUserName);
                    }
                    else
                    {
                        Console.WriteLine($"The username {initialUserName} doesn't contain {substring2}.");
                    }
                    break;
                case "Replace":
                    char symbol  = char.Parse(input[1]);
                    if (initialUserName.Contains(symbol))
                    {
                        initialUserName = initialUserName.Replace(symbol,'-');
                        Console.WriteLine(initialUserName);
                    }
                    break;
                case "IsValid":
                    char symbol2 = char.Parse(input[1]);
                    if (initialUserName.Contains(symbol2))
                    {
                        Console.WriteLine($"Valid username.");
                    }
                    else
                    {
                        Console.WriteLine($"{symbol2} must be contained in your username.");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}