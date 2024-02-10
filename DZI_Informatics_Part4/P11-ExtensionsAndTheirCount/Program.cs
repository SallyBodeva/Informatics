namespace P11_ExtensionsAndTheirCount
{
    internal class Program
    {
        static void Main()
        {
            string path = @"C:\Users\EliteBook\Desktop\test.txt";
            Dictionary<string, int> files = new Dictionary<string, int>();

            string text = File.ReadAllText(path);

            Console.WriteLine(text);
            string[] textArray = text.Split(Environment.NewLine);

            Console.WriteLine(string.Join(" ",textArray));
        }
        //TODO
    }
}
