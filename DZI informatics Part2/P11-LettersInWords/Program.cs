using System;
using System.Linq;


namespace P11_LettersInWords
{
    public class Program
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(' ');
            foreach (var word in text)
            {
                for (char i = 'а'; i <= 'я'; i++)
                {
                    int count = 0;
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (word[j]==i)
                        {
                            count++;
                        }
                    }
                    if (count>1)
                    {
                        for (int k = 0; k < count-1; k++)
                        {
                            word.Remove(i);
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ",text));
        }
    }
}
