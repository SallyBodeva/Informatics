namespace P22_TheGambler_Matrix_
{
    internal class Program
    {
        private static int money = 100;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] board = new char[n, n];

            ReadElements(board);
            while (true)
            {
               // string commmand = Console.ReadLine(); ;
                ConsoleKey k = Console.ReadKey().Key;
                switch (k)
                {
                    case ConsoleKey.UpArrow:
                        Up(board);
                        break;
                    case ConsoleKey.DownArrow:
                        Down(board);
                        break;
                    case ConsoleKey.RightArrow:
                        Right(board);
                        break;
                    case ConsoleKey.LeftArrow:
                        Left(board);
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine($"End of the game. Total amount: {money}$");
                        PrintMatrix(board);
                        Environment.Exit(0);
                        break;
                }
            }

        }
        public static int[] CurrentPosition(char[,] matrix, char targetSymbol)
        {
            int[] result = new int[2];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == targetSymbol)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }
        public static void Up(char[,] matrix)
        {
            try
            {
                int indexRow = CurrentPosition(matrix, 'G')[0];
                int indexCol = CurrentPosition(matrix, 'G')[1];

                int indexUpRow = indexRow - 1;
                switch (matrix[indexUpRow, indexCol])
                {
                    case '-':
                        matrix[indexUpRow, indexCol] = 'G';
                        matrix[indexRow, indexCol] = '-';
                        break;
                    case 'W':
                        matrix[indexUpRow, indexCol] = 'G';
                        matrix[indexRow, indexCol] = '-';
                        money += 100;
                        break;
                    case 'P':
                        matrix[indexUpRow, indexCol] = 'G';
                        matrix[indexRow, indexCol] = '-';
                        money -= 200;
                        break;
                    case 'J':
                        matrix[indexUpRow, indexCol] = 'G';
                        matrix[indexRow, indexCol] = '-';
                        money += 100000;
                        Console.WriteLine("You win the Jackpot!");
                        Console.WriteLine($"End of the game. Total amount: {money}$");
                        PrintMatrix(matrix);
                        Environment.Exit(0);
                        break;
                }
                if (money<=0)
                {
                    Console.WriteLine("Game over! You lost everything!");
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Game over! You lost everything!");
                Environment.Exit(0);
            }

        }
        public static void Right(char[,] matrix)
        {
            try
            {
                int indexRow = CurrentPosition(matrix, 'G')[0];
                int indexCol = CurrentPosition(matrix, 'G')[1];

                int indexRightCol = indexCol + 1;
                switch (matrix[indexRow, indexRightCol])
                {
                    case '-':
                        matrix[indexRow, indexRightCol] = 'G';
                        matrix[indexRow, indexCol] = '-';
                        break;
                    case 'W':
                        matrix[indexRow, indexRightCol] = 'G';
                        matrix[indexRow, indexCol] = '-';
                        money += 100;
                        break;
                    case 'P':
                        matrix[indexRow, indexRightCol] = 'G';
                        matrix[indexRow, indexCol] = '-';
                        money -= 200;
                        break;
                    case 'J':
                        matrix[indexRow, indexRightCol] = 'G';
                        matrix[indexRow, indexCol] = '-';
                        money += 100000;
                        Console.WriteLine("You win the Jackpot!");
                        Console.WriteLine($"End of the game. Total amount: {money}$");
                        PrintMatrix(matrix);
                        Environment.Exit(0);
                        break;
                }
                if (money <= 0)
                {
                    Console.WriteLine("Game over! You lost everything!");
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Game over! You lost everything!");
                Environment.Exit(0);
            }

        }
        public static void Left(char[,] matrix)
        {
            try
            {
                int indexRow = CurrentPosition(matrix, 'G')[0];
                int indexCol = CurrentPosition(matrix, 'G')[1];

                int indexLeftCol = indexCol - 1;
                switch (matrix[indexRow, indexLeftCol])
                {
                    case '-':
                        matrix[indexRow, indexLeftCol] = 'G';
                        matrix[indexRow, indexCol] = '-';
                        break;
                    case 'W':
                        matrix[indexRow, indexLeftCol] = 'G';
                        matrix[indexRow, indexCol] = '-';
                        money += 100;
                        break;
                    case 'P':
                        matrix[indexRow, indexLeftCol] = 'G';
                        matrix[indexRow, indexCol] = '-';
                        money -= 200;
                        break;
                    case 'J':
                        matrix[indexRow, indexLeftCol] = 'G';
                        matrix[indexRow, indexCol] = '-';
                        money += 100000;
                        Console.WriteLine("You win the Jackpot!");
                        Console.WriteLine($"End of the game. Total amount: {money}$");
                        PrintMatrix(matrix);
                        Environment.Exit(0);
                        break;
                }
                if (money <= 0)
                {
                    Console.WriteLine("Game over! You lost everything!");
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Game over! You lost everything!");
                Environment.Exit(0);
            }

        }
        public static void Down(char[,] matrix)
        {
            try
            {
                int indexRow = CurrentPosition(matrix, 'G')[0];
                int indexCol = CurrentPosition(matrix, 'G')[1];

                int indexDownRow = indexRow + 1;
                switch (matrix[indexDownRow, indexCol])
                {
                    case '-':
                        matrix[indexDownRow, indexCol] = 'G';
                        matrix[indexRow, indexCol] = '-';
                        break;
                    case 'W':
                        matrix[indexDownRow, indexCol] = 'G';
                        matrix[indexRow, indexCol] = '-';
                        money += 100;
                        break;
                    case 'P':
                        matrix[indexDownRow, indexCol] = 'G';
                        matrix[indexRow, indexCol] = '-';
                        money -= 200;
                        break;
                    case 'J':
                        matrix[indexDownRow, indexCol] = 'G';
                        matrix[indexRow, indexCol] = '-';
                        money += 100000;
                        Console.WriteLine("You win the Jackpot!");
                        Console.WriteLine($"End of the game. Total amount: {money}$");
                        PrintMatrix(matrix);
                        Environment.Exit(0);
                        break;
                }
                if (money <= 0)
                {
                    Console.WriteLine("Game over! You lost everything!");
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Game over! You lost everything!");
                Environment.Exit(0);
            }

        }

        private static void PrintMatrix(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write($"{board[i, j]}");
                }
                Console.WriteLine();
            }
        }

        private static void ReadElements(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                string line = Console.ReadLine();
                char[] row = line.ToCharArray();
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = row[j];
                }
            }
        }
    }
}
