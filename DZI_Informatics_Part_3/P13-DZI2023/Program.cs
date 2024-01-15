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
                        foreach (var item in list)
                        {
                            if (char.IsLetter(item[0]))
                            {
                                string newWord = char.ToUpper(item[0]) + item.Substring(1);
                                
                            }
                        }
                        break;
                }
            }
        }
    }
}
