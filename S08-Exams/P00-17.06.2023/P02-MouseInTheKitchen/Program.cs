using System;
using System.Linq;

namespace P01_MouseInTheKitchen
{
    public class Program
    {
        static void Main()
        {
            int[] matrixInfo = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int matrixRows = matrixInfo[0];

            char[][] matrix = new char[matrixRows][];
            ReadArray(matrix, matrixRows);

            while (true)
            {
                int[] mousePosition = FindMousePosition(matrix);
                char adjecentSymbol;
                string input = Console.ReadLine();
                if (input == "danger")
                {
                    Console.WriteLine("Mouse will come back later!");
                    PrintMatrix(matrix);
                    break;
                }
                try
                {
                    switch (input)
                    {
                        case "left":
                            adjecentSymbol = FindAdjacentSymbol(matrix, mousePosition, "left");
                            MoveLeft(matrix, mousePosition, adjecentSymbol);
                            break;
                        case "right":
                            adjecentSymbol = FindAdjacentSymbol(matrix, mousePosition, "right");
                            MoveRight(matrix, mousePosition, adjecentSymbol);
                            break;
                        case "up":
                            adjecentSymbol = FindAdjacentSymbol(matrix, mousePosition, "up");
                            MoveUp(matrix, mousePosition, adjecentSymbol);
                            break;
                        case "down":
                            adjecentSymbol = FindAdjacentSymbol(matrix, mousePosition, "down");
                            MoveDown(matrix, mousePosition, adjecentSymbol);
                            break;

                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("No more cheese for tonight!");
                    PrintMatrix(matrix);
                    Environment.Exit(0);
                }

            }
        }
        public static char FindAdjacentSymbol(char[][] matrix, int[] currentP, string direction)
        {
            char symbol = 't';
            int row = currentP[0];
            int col = currentP[1];
            switch (direction)
            {
                case "left":
                    symbol = matrix[row][col - 1];
                    break;
                case "right":
                    symbol = matrix[row][col + 1];
                    break;
                case "up":
                    symbol = matrix[row - 1][col];
                    break;
                case "down":
                    symbol = matrix[row + 1][col];
                    break;
            }
            return symbol;
        }
        public static int[] FindMousePosition(char[][] matrix)
        {
            int[] p = new int[2];
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 'M')
                    {
                        p[0] = i;
                        p[1] = j;
                    }
                }
            }
            return p;
        }
        public static void ReadArray(char[][] matrix, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }
        }
        public static void PrintMatrix(char[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(String.Join("", matrix[i]));
            }
        }
        public static void MoveLeft(char[][] m, int[] currentPosition, char nextSymbol)
        {
            int row = currentPosition[0];
            int col = currentPosition[1];
            int[] targetPlace = new int[2] { row, col - 1 };
            if (nextSymbol == '*')
            {
                Swap(m, targetPlace, currentPosition);
            }
            else if (nextSymbol == 'C')
            {
                Swap(m, targetPlace, currentPosition);
                m[currentPosition[0]][currentPosition[1]] = '*';
                if (!ContainsSymbol(m, 'C'))
                {
                    Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                    PrintMatrix(m);
                    Environment.Exit(0);
                }
            }
            else if (nextSymbol == 'T')
            {
                Swap(m, targetPlace, currentPosition);
                m[currentPosition[0]][currentPosition[1]] = '*';
                Console.WriteLine("Mouse is trapped!");
                PrintMatrix(m);
                Environment.Exit(0);

            }
        }
        public static void MoveRight(char[][] m, int[] currentPosition, char nextSymbol)
        {
            int row = currentPosition[0];
            int col = currentPosition[1];
            int[] targetPlace = new int[2] { row, col + 1 };
            if (nextSymbol == '*')
            {
                Swap(m, targetPlace, currentPosition);
            }
            else if (nextSymbol == 'C')
            {
                Swap(m, targetPlace, currentPosition);
                m[currentPosition[0]][currentPosition[1]] = '*';
                if (!ContainsSymbol(m, 'C'))
                {
                    Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                    PrintMatrix(m);
                    Environment.Exit(0);
                }
            }
            else if (nextSymbol == 'T')
            {
                Swap(m, targetPlace, currentPosition);
                m[currentPosition[0]][currentPosition[1]] = '*';
                Console.WriteLine("Mouse is trapped!");
                PrintMatrix(m);
                Environment.Exit(0);
            }

        }
        public static void MoveUp(char[][] m, int[] currentPosition, char nextSymbol)
        {
            int row = currentPosition[0];
            int col = currentPosition[1];
            int[] targetPlace = new int[2] { row - 1, col };
            if (nextSymbol == '*')
            {
                Swap(m, targetPlace, currentPosition);
            }
            else if (nextSymbol == 'C')
            {
                Swap(m, targetPlace, currentPosition);
                m[currentPosition[0]][currentPosition[1]] = '*';
                if (!ContainsSymbol(m, 'C'))
                {
                    Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                    PrintMatrix(m);
                    Environment.Exit(0);
                }
            }
            else if (nextSymbol == 'T')
            {
                Swap(m, targetPlace, currentPosition);
                m[currentPosition[0]][currentPosition[1]] = '*';
                Console.WriteLine("Mouse is trapped!");
                PrintMatrix(m);
                Environment.Exit(0);
            }

        }
        public static void MoveDown(char[][] m, int[] currentPosition, char nextSymbol)
        {
            int row = currentPosition[0];
            int col = currentPosition[1];
            int[] targetPlace = new int[2] { row + 1, col };
            if (nextSymbol == '*')
            {
                Swap(m, targetPlace, currentPosition);
            }
            else if (nextSymbol == 'C')
            {
                Swap(m, targetPlace, currentPosition);
                m[currentPosition[0]][currentPosition[1]] = '*';
                if (!ContainsSymbol(m, 'C'))
                {
                    Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                    PrintMatrix(m);
                    Environment.Exit(0);
                }
            }
            else if (nextSymbol == 'T')
            {
                Swap(m, targetPlace, currentPosition);
                m[currentPosition[0]][currentPosition[1]] = '*';
                Console.WriteLine("Mouse is trapped!");
                PrintMatrix(m);
                Environment.Exit(0);
            }

        }
        public static bool ContainsSymbol(char[][] m, char symbol)
        {
            foreach (char[] innerArray in m)
            {
                foreach (char element in innerArray)
                {
                    if (element == symbol)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        private static void Swap(char[][] matrix, int[] targetPlace, int[] currentPLace)
        {
            char t = matrix[targetPlace[0]][targetPlace[1]];
            matrix[targetPlace[0]][targetPlace[1]] = matrix[currentPLace[0]][currentPLace[1]];
            matrix[currentPLace[0]][currentPLace[1]] = t;
        }
    }
}