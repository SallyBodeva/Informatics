namespace P22_TheGambler_Matrix_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] board = new string[n, n];

            ReadElements(board);
            PrintMatrix(board);
            string commmand = string.Empty;
            while ((commmand=Console.ReadLine())!="end")
            {
                switch (commmand)
                {
                    case "up":

                        break;
                }
            }
        }
        public static void Up(int[,] matrix)
        {

        }

        private static void PrintMatrix(string[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write($"{board[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        private static void ReadElements(string[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                string[] row = Console.ReadLine().Split(" ").ToArray();
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = row[j];
                }
            }
        }
    }
}
