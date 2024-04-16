public class Program
{
    static void Main()
    {
        string concealedMessage = Console.ReadLine();
        while (true)
        {
            string[] input = Console.ReadLine().Split(":|:");
            if (input[0]== "Reveal")
            {
                Console.WriteLine($"You have a new text message: {concealedMessage}");
                Environment.Exit(0);
            }
            string cmd = input[0];
            switch (cmd)
            {
                case "InsertSpace":
                    int index = int.Parse(input[1]);
                    concealedMessage = concealedMessage.Insert(index, " ");
                    Console.WriteLine(concealedMessage);
                    break;
                case "Reverse":
                    string substring = input[1];
                    if (concealedMessage.Contains(substring))
                    {
                        concealedMessage = concealedMessage.Replace(substring, "");
                        string reversedSubstring = new string(substring.Reverse().ToArray());
                        concealedMessage = concealedMessage + reversedSubstring;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    Console.WriteLine(concealedMessage);
                    break;
                case "ChangeAll":
                     substring = input[1];
                    string replacement = input[2];
                    concealedMessage = concealedMessage.Replace(substring, replacement);
                    Console.WriteLine(concealedMessage);
                    break;
            }
        }
    }
}
