namespace P01_RotateMatrix
{
    public  class Program
    {
        static void Main()
        {
            int[,] matrix = ReadMatix();
            PrintMatrix(matrix);


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
