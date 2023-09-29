using System;
using System.Security.Cryptography.X509Certificates;

namespace P04_WordGame
{
    public class Program
    {
        static void Main()
        {
            string word = string.Empty;
            string winnerWord = string.Empty;
            int maxPoint = int.MinValue;
            while ((word=Console.ReadLine())!="END OF GAME")
            {
                int wordPoints = 0;
                foreach (var letter in word)
                {
                    wordPoints += letter;
                }
                if (word[0]>=65 && word[0]<=90)
                {
                    wordPoints += 15;
                }
                if (word[word.Length-1]=='t')
                {
                    wordPoints += 20;
                }
                if (word.Length>=10)
                {
                    wordPoints += 30;
                }
                if (wordPoints>maxPoint)
                {
                    winnerWord = word;
                    maxPoint = wordPoints;
                }
                wordPoints = 0;
            }
            Console.WriteLine($"Winner is word: {winnerWord}");
            Console.WriteLine($"Points: {maxPoint}");
        }
    }
}
