namespace P08_UpperCaseString
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int openTagIndex = input.IndexOf("e>");
            int closeTagIndex = input.LastIndexOf("</>");

            string wordToUpperCase = input.Substring(openTagIndex, input.Length - closeTagIndex);
            Console.WriteLine(wordToUpperCase);

            //TODO
        }
    }
}
