namespace P22_CountUppercaseWords
{
    public class Program
    {
        static void Main()
        {
            string[] info = File.ReadAllText(@"C:\Users\EliteBook\Desktop\Informatics\DZI_Informatics_Part4\P22-CountUppercaseWords\Info.txt").Split(" ");
            List<string> upperCaseWords =new List<string>();
            foreach (var word in info)
            {
                if (char.IsUpper(word[0]))
                {
                    upperCaseWords.Add(word);
                }
            }
            Console.WriteLine(string.Join(" ",upperCaseWords));
        }
    }
}
