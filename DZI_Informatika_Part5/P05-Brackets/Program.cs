using System.Xml;

namespace P05_Brackets
{
    internal class Program
    {
        static void Main()
        {
            string lines = File.ReadAllText(@"C:\Users\EliteBook\Desktop\Informatics\DZI_Informatika_Part5\P05-Brackets\Input.txt");
         //   Console.WriteLine(lines);

            Stack<int> openBrackets = new Stack<int>();
            Queue<int> clsoeBrackets = new Queue<int>();
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == '(')
                {
                    openBrackets.Push(i);
                }
                if (lines[i] == ')')
                {
                    clsoeBrackets.Enqueue(i);
                }
            }
            while (openBrackets.Count != 0 && clsoeBrackets.Count != 0)
            {
                int openIndex = openBrackets.Pop();
                int closeIdndex = clsoeBrackets.Dequeue();
                string text = lines.Substring(openIndex, closeIdndex - openIndex+1);

                File.AppendAllText(@"C:\Users\EliteBook\Desktop\Informatics\DZI_Informatika_Part5\P05-Brackets\Output.txt",$"{text}{Environment.NewLine}");
                Console.WriteLine(text);
            }

        }
    }
}
