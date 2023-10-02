using System;
using System.Collections.Generic;
using System.Linq;

namespace P09_ListOfWords
{
    public class Program
    {
        static void Main()
        {
            List<string> words = new List<string>();
            while (true)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();
                if (info[0] == "END")
                {
                    break;
                }
                switch (info[0])
                {
                    case "Add":
                        for (int i = 1; i < info.Length; i++)
                        {
                            words.Add(info[i]);
                        }
                        break;
                    case "Update":
                        for (int i = 0; i < words.Count; i++)
                        {
                            if (char.IsLetter(words[i][0]))
                            {
                                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                            }
                        }
                        break;
                    case "Remove":
                        int index = int.Parse(info[1]);
                        words.RemoveAt(index);
                        break;
                    case "Search":
                        string targetWord = info[1];
                        if (words.Contains(targetWord))
                        {
                            Console.WriteLine(targetWord);
                        }
                        else
                        {
                            Console.WriteLine("Not contained.");
                        }
                        break;
                    case "Insert":
                        int index1 = int.Parse(info[1]);
                        string word = info[2];
                        try
                        {
                            words.Insert(index1, word);
                        }
                        catch(Exception)
                        {
                            Console.WriteLine("There are not enough items in the list.");
                        }
                    
                        break;
                    case "Print":
                        Console.WriteLine(string.Join("; ",words));
                        break;
                }
            }
        }
    }
}
//