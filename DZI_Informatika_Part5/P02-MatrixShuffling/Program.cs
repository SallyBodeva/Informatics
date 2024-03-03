namespace P02_MatrixShuffling
{
    internal class Program
    {
        static void Main()
        {
            int[] dimentions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[dimentions[0], dimentions[1]];
            ReadMatrix(matrix);
            string cmd = string.Empty;
            while ((cmd = Console.ReadLine()) != "End")
            {
                try
                {
                    string[] info = cmd.Split(" ");
                    string word = info[0];
                    if (word != "swap")
                    {
                        throw new Exception();
                    }
                    int startRow = int.Parse(info[1]);
                    int startCol = int.Parse(info[2]);
                    int destRow = int.Parse(info[3]);
                    int destCol = int.Parse(info[4]);
                    Swap(matrix, startRow, startCol, destRow, destCol);
                    PrintMatrix(matrix);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                }
            }

        }

        private static void Swap(int[,] matrix, int startRow, int startCol, int destRow, int destCol)
        {
            int first = matrix[startRow, startCol];
            matrix[startRow, startCol] = matrix[destRow, destCol];
            matrix[destRow, destCol] = first;
        }


        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        private static void ReadMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] elemnts = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = elemnts[j];
                }
            }
        }
    }
}
