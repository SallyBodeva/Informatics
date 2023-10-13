using System;

namespace P22_MatrixMethods
{
    public class Program
    {
        static void Main()
        {
            char[,] wordMatrix = new char[,]{
                 { 'H', 'E', 'L', 'L', 'O' },
                 { 'W', 'O', 'R', 'L', 'D' },
                 { 'M', 'A', 'T', 'R', 'I' },
                 { 'E', 'X', 'A', 'M', 'P'}
                 };
            Console.WriteLine(DoesItContain(wordMatrix,"WORLD"));
        }
        public static bool DoesItContain(char[,] matrix, string target)
        {
            int numRows = matrix.GetLength(0);
            int numCols = matrix.GetLength(1);
            int targetLength = target.Length;

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col <= numCols - targetLength; col++)
                {
                    bool found = true;
                    for (int i = 0; i < targetLength; i++)
                    {
                        if (matrix[row, col + i] != target[i])
                        {
                            found = false;
                            break;
                        }
                    }
                    if (found)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
       // To do
    }
}
