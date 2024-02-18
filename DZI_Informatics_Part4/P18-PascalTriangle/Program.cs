namespace P18_PascalTriangle
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[][] pTriangle = new int[n][];
            int lineLength = 1;
            for (int i = 0; i < pTriangle.GetLength(0); i++)
            {
                pTriangle[i] = new int[lineLength];
                lineLength++;
            }
            for (int i = 0; i < pTriangle.GetLength(0); i++)
            {
                for (int j = 0; j < pTriangle[i].Length; j++)
                {
                    if (j==0 || j == pTriangle[i].Length-1)
                    {
                        pTriangle[i][j] = 1;
                    }
                    else
                    {
                        pTriangle[i][j] = pTriangle[i - 1][j] + pTriangle[i - 1][j - 1];
                    }
                }
            }
            PrintJeggedArray(pTriangle);
        }
       
        public static void PrintJeggedArray(int[][] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine(string.Join(" ", array[i]));
            }
            
        }
    }
}
