namespace P09_StringOperation
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(DublicateTheFirst2Symbols("Salihe"));
        }
        public static string RemoveLetter(string word, int index)
        {
            word = word.Remove(index,1);
            return word;
        }
        public static string Swap(string word)
        {
            char[] newWord = word.ToCharArray();
            newWord[0] = word[word.Length - 1];
            word.CopyTo(1, newWord, 1, word.Length - 2);
            newWord[word.Length - 1] = word[0];
            string result = new string(newWord);
            return result;

        }
        public static string DublicateTheFirst2Symbols(string word)
        {
            string firstSymbols = $"{word[0]}{word[1]}";
            for (int i = 0; i < 4; i++)
            {
                firstSymbols += firstSymbols;
            }
            return firstSymbols;
        }


        //TODO
    }
}
