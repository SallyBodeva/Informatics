namespace P01_SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            char[,] matrix = new char[dimentions[0], dimentions[1]];
            ReadMatrix(matrix);
            PrintMatrix(matrix);




            Console.WriteLine(FindBoxesInMatrix(matrix));
        }
        private static int FindBoxesInMatrix(char[,] matrix)
        {
            int count = 0;
            try
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i,j] == matrix[i+1, j] && 
                            matrix[i, j] == matrix[i, j+1] &&
                            matrix[i, j] == matrix[i+1, j + 1])
                        {
                            count++;
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            return count;
         
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
