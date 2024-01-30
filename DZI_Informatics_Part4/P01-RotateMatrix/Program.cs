namespace P01_RotateMatrix
{
    public  class Program
    {
        static void Main()
        {
            int[,] matrix = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };

            PrintMatrix(matrix);
            PrintMatrix(Rotate(matrix));
        }
        public static int[,] Rotate(int[,] matrix)
        {
            int i = 0;
            int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int j = 0;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    newMatrix[col, 3-row] = matrix[row,col];
                    j++;
                }
                i++;
            }
            return newMatrix;
        }
        public static int[,] ReadMatix()
        {
            int[,] matrix = new int[4, 4];
            Random rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10); 
                }
            }
            return matrix;
        }
        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
