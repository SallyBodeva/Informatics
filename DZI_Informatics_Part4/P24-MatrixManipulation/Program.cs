namespace P24_MatrixManipulation

{
    internal class Program
    {
        static void Main()
        {


            Console.WriteLine(string.Join(" ", File.ReadAllLines(@"C:\Users\EliteBook\Desktop\test.txt")[0]));
            Console.WriteLine(File.ReadAllLines(@"C:\Users\EliteBook\Desktop\test.txt")[0].Split(" ").Length);
        }
        public int[,] ReadMatrix(string pathName)
        {
            int rows = File.ReadAllLines(pathName).Length;
            int col = File.ReadAllLines(pathName)[0].Split(" ").Length;
            int[,] matrix = null;
            try
            {
                matrix = new int[rows, col];
                if (rows!=col)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid data.");
            }
            return matrix;

        }
    }
}
