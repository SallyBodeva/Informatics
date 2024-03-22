public class Program
{
    private static int countT1 = 0;
    private static int countT2 = 0;
    private static int countT3 = 0;
    private static int countT4 = 0;
    public static void Main()
    {
        string b = Console.ReadLine();
        Stack<char> s = new Stack<char>(b.Where(x => x == '(' || x == '<' || x == '{' || x == '['));
        Queue<char> q = new Queue<char>(b.Where(x => x == ')' || x == '>' || x == '}' || x == ']'));

        if (s.Count != q.Count) { Console.WriteLine("Invalid Expression."); Environment.Exit(0); }
        while (s.Any() && q.Any())
        {
            char open = s.Pop();
            char close = q.Dequeue();
            if (open == '(' && close == ')') { countT1++; }
            else if (open == '<' && close == '>') { countT2++; }
            else if (open == '{' && close == '}') { countT3++; }
            else if (open == '[' && close == ']') { countT4++; }
            else { Console.WriteLine("Invalid Expression."); Environment.Exit(0); }
        }
        Console.WriteLine($"Bractes type ( ) - {countT1}\nBractes type < > - {countT2}\nBractes type {{ }} > - {countT3}\nBractes type [ ] - {countT4}");

    }
}
