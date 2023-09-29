using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace P02_DeliveryBoy
{
    public class Program
    {
        static void Main()
        {
            int[] sizes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            char[][] matrix = new char[sizes[0]][];
            ReadMatrix(sizes, matrix);
            PrintMatrix(matrix);
            FindThePsotion(matrix,'B');
            while (true)
            {
                string commmand = Console.ReadLine();
                int row = FindThePsotion(matrix,'B')[0];
                int col = FindThePsotion(matrix,'B')[1];
                switch (commmand)
                {
                    case "up":
                        Up(row, col, matrix);
                        PrintMatrix(matrix);
                        break;
                    case "down":
                        Down(row, col, matrix);
                        PrintMatrix(matrix);
                        break;
                    default:
                        break;
                }
            }
            //To do
        }
        public static void Up(int row,int col, char[][]matrix)
        {
            if (row-1<0)
            {
                Console.WriteLine("The delivery is late. Order is canceled.");
                Environment.Exit(0);
            }
            else
            {
                if (matrix[row - 1][col] == '-')
                {
                    matrix[row][col] = '.';
                }
                if (matrix[row - 1][col] == 'A')
                {
                    matrix[row - 1][col] = 'P';
                    Console.WriteLine("Pizza is delivered on time! Next order...");
                }
                if (matrix[row - 1][col] == 'P')
                {
                    matrix[row - 1][col] = 'R';
                    matrix[row][col] = '.';
                    row = FindThePsotion(matrix, 'R')[0];
                    col = FindThePsotion(matrix, 'R')[0];
                    Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
                }
              
            }
        }
        public static void Down(int row, int col, char[][] matrix)
        {
            if (row + 1 >= matrix.GetLength(0))
            {
                Console.WriteLine("The delivery is late. Order is canceled.");
                Environment.Exit(0);
            }
            else
            {
                if (matrix[row + 1][col] == '-')
                {
                    matrix[row][col] = '.';
                }
                if (matrix[row + 1][col] == 'A')
                {
                    matrix[row + 1][col] = 'P';
                    Console.WriteLine("Pizza is delivered on time! Next order...");
                }
                if (matrix[row + 1][col] == 'P')
                {
                    matrix[row + 1][col] = 'R';
                    matrix[row][col] = '.';
                    row = FindThePsotion(matrix, 'R')[0];
                    col = FindThePsotion(matrix, 'R')[0];
                    Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
                }

            }
        }


        private static int[] FindThePsotion(char[][] matrix,char symbol)
        {
            int[] position = new int[2];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == symbol)
                    {
                        position[0] = i;
                        position[1] = j;
                    }
                }
            }
            return position;
        }

        private static void PrintMatrix(char[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join("", matrix[i]));
            }
        }

        private static void ReadMatrix(int[] sizes, char[][] matrix)
        {
            for (int i = 0; i < sizes[0]; i++)
            {
                string line = Console.ReadLine();
                matrix[i] = line.ToCharArray();
            }
        }
    }
}
