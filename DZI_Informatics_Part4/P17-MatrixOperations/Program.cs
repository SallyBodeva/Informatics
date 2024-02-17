namespace P17_MatrixOperations
{
    public class Program
    {
        static void Main()
        {
            int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[,] matrix = ReadMatrix(coordinates[0], coordinates[1]);
            SumMatrixColumns(matrix);
        }
        public static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                int[] ints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = ints[j];
                }
            }
            return matrix;
        }
        public static void SumMatrixColumns(int[,] matrix)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int sum = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += matrix[i, j];
            
                }
                  Console.WriteLine(sum);
            }

          
        }
        public static int SumMatrixElements(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += (matrix[i, j]);
                }
            }
            return sum;
        }

    }
}
