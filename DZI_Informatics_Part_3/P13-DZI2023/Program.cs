namespace P13_DZI2023
{
    internal class Program
    {
        static void Main()
        {
            List<string> list = new List<string>();
            while (true)
            {
                string[] commands = Console.ReadLine().Split(' ').ToArray();
                if (commands[0]=="End")
                {
                    break;
                }
                switch (commands[0])
                {
                    case "Add":
                        for (int i = 1; i < commands.Length; i++)
                        {
                            list.Add(commands[i]);
                        }
                        break;
                    case "Update":
                        for (int i = 0; i < list.Count; i++)
                        {
                            string currentWord = list[i];
                            if (char.IsLetter(currentWord[0]))
                            {
                                string newWord = char.ToUpper(currentWord[0]) + currentWord.Substring(1);
                                list[i] = newWord;
                            }
                        }
                        break;
                    case "Remove":
                        int index = int.Parse(commands[1]);
                        list.RemoveAt(index);
                        break;
                    case "Search":
                        if (list.Contains(commands[1]))
                        {
                            Console.WriteLine(commands[1]);
                        }
                        else
                        {
                            Console.WriteLine("Not contained.");
                        }
                        break;
                    case "Length":
                        int length = int.Parse(commands[1]);
                        List<string> wordsWithLength = list.Where(x => x.Length == length).ToList();
                        if (wordsWithLength.Count>0)
                        {
                            Console.WriteLine(string.Join("-",wordsWithLength));
                        }
                        else
                        {
                            Console.WriteLine("Not contained.");
                        }
                        break;
                    case "Insert":
                        int indexInsert = int.Parse(commands[1]);
                        string word = commands[2];
                        try
                        {
                            list.Insert(indexInsert, word);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("There are not enough items in the list.");
                        }
                        break;
                    case "Print":
                        Console.WriteLine(string.Join("; ",list));
                        break;
                }
            }
        }
    }
}
