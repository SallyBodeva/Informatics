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
                        if (list.Contains(commands[2]))
                        {
                            Console.WriteLine();
                        }
                        break;
                }
            }
        }
    }
}
