using System.Threading.Tasks.Dataflow;

namespace P08_EncryptWord
{
    public class Program
    {
        static void Main()
        {
            string word = Console.ReadLine().ToUpper();
            List<char> newWordFormation = word.ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                newWordFormation.Insert(0, newWordFormation[newWordFormation.Count - 1]);
                newWordFormation.RemoveAt(newWordFormation.Count - 1);
            }
            Console.WriteLine(string.Join("",newWordFormation));

            for (int i = 0; i < newWordFormation.Count; i++)
            {
                int ascciNum = (int)newWordFormation[i] +n;
                char newLetter = (char)ascciNum; 
                newWordFormation[i] = newLetter;
            }
            Console.WriteLine(string.Join("", newWordFormation));
        }
    }
}
