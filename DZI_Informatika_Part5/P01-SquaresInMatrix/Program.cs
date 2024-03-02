namespace P01_SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = new char[3, 3];
            ReadMatrix(matrix);
            PrintMatrix(matrix);
        }
        private static void FindBoxesInMatrix(char[,] matrix)
        {
            try
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i,j] == matrix[i-1, j] && matrix[i, j] == matrix[i - 1, j])
                        {
                            //TODO
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
         
        }

        private static void PrintMatrix(char[,] matrix)
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

        private static void ReadMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] elemnts = Console.ReadLine().Split(" ").Select(char.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = (char)elemnts[j];
                }
            }
        }
    }
}
