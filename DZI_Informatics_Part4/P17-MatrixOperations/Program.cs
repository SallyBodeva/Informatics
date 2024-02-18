namespace P17_MatrixOperations
{
    public class Program
    {
        static void Main()
        {
            int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[][] matrix = ReadJaggedArray(coordinates[0]);
            int[][] newMatrfxi = JaggedArrayModification(matrix);
            PrintJaggedArray(newMatrfxi);

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
        public static int[][] ReadJaggedArray(int n)
        {
            int[][] array = new int[n][];
            for (int i = 0; i < n; i++)
            {
                array[i] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            }
            return array;
        }
        public static void PrintJaggedArray(int[][] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
        public static void PrintMatrix(int[,] matrix)
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
        public static int PrimaryDiagonal(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
        public static char[][] ReadCharArray(int n)
        {
            char[][] array = new char[n][];
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                array[i] = line.ToCharArray();
            }
            return array;
        }
        public static string SymbolInMatrix(char[][] matrix)
        {
            char symbol = char.Parse(Console.ReadLine());
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == symbol)
                    {
                        return $"({i}, {j})";
                    }
                }
            }
            return $"{symbol} does not occur in the matrix";
        }
        public static int[][] JaggedArrayModification(int[][] matrix)
        {
            string cmd = string.Empty;
            while ((cmd = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] data = cmd.Split(' ');
                    switch (data[0])
                    {
                        case "Add":
                            int row = int.Parse(data[1]);
                            int col = int.Parse(data[2]);
                            matrix[row][col] += int.Parse(data[3]);
                            break;
                        case "Subtract":
                            int r = int.Parse(data[1]);
                            int c = int.Parse(data[2]);
                            matrix[r][c] -= int.Parse(data[3]);
                            break;

                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }
            return matrix;
        }
    }
}
