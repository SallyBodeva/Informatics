namespace P10_FishingCompetition
{
    internal class Program
    {
        private static  int sum = 0;
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[][] array = ReadArray(n);
            while (true)
            {
                string command = Console.ReadLine();
                if (command== "collect the nets")
                {
                    break;
                }
                switch (command)
                {
                    case "up":
                        Up(array, FindIndexes(array, 'S'));
                        break;
                    case "down":
                        Down(array, FindIndexes(array, 'S'));
                        break;
                    case "right":
                        Right(array, FindIndexes(array, 'S'));
                        break;
                    case "left":
                        Left(array, FindIndexes(array, 'S'));
                        break;
                }
            }
            if (sum>=20)
            {
                Console.WriteLine("Success! You managed to reach the quota!");
            }
            else
            {
                Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20-sum} tons of fish more.");
            }
            Console.WriteLine($"Amount of fish caught: {sum} tons.");
            PrintArray(array);

        }
        public static void Up(char[][] array, int[] coordinatesOfShip)
        {
            int row = coordinatesOfShip[0];
            int upRow = row- 1;
            if (upRow<0)
            {
                upRow = array.GetLength(0) - 1;
            }
            int col = coordinatesOfShip[1];

            if (array[upRow][col]=='-')
            {
                array[upRow][col] = 'S';
                array[row][col] = '-';
            }
            else if (char.IsDigit(array[upRow][col]))
            {
                sum += int.Parse(array[upRow][col].ToString());
                array[upRow][col] = 'S';
                array[row][col] = '-';
            }
            else
            {
                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{upRow},{col}]");
                Environment.Exit(0);
            }
        }
        public static void Right(char[][] array, int[] coordinatesOfShip)
        {
            int row = coordinatesOfShip[0];
            int col = coordinatesOfShip[1];
            int rightCol = col + 1;
            if (rightCol >= array[row].Length)
            {
                rightCol = 0;
            }
            if (array[row][rightCol] == '-')
            {
                array[row][rightCol] = 'S';
                array[row][col] = '-';
            }
            else if (char.IsDigit(array[row][rightCol]))
            {
                sum += int.Parse(array[row][rightCol].ToString());
                array[row][col] = '-';
                array[row][rightCol] = 'S';
            }
            else
            {
                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{rightCol},{col}]");
                Environment.Exit(0);
            }
        }
        public static void Left(char[][] array, int[] coordinatesOfShip)
        {
            int row = coordinatesOfShip[0];
            int col = coordinatesOfShip[1];
            int leftCol = col - 1;
            if (leftCol < 0)
            {
                leftCol = array[row].Length-1;
            }
            if (array[row][leftCol] == '-')
            {
                array[row][leftCol] = 'S';
                array[row][col] = '-';
            }
            else if (char.IsDigit(array[row][leftCol]))
            {
                sum += int.Parse(array[row][leftCol].ToString());
                array[row][col] = '-';
                array[row][leftCol] = 'S';
            }
            else
            {
                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{leftCol},{col}]");
                Environment.Exit(0);
            }
        }
        public static void Down(char[][] array, int[] coordinatesOfShip)
        {
            int row = coordinatesOfShip[0];
            int downRow = row + 1;
            if (downRow >= array.GetLength(0))
            {
                downRow = 0;
            }
            int col = coordinatesOfShip[1];

            if (array[downRow][col] == '-')
            {
                array[downRow][col] = 'S';
                array[row][col] = '-';
            }
            else if (char.IsDigit(array[downRow][col]))
            {
                sum += int.Parse(array[downRow][col].ToString());
                array[row][col] = '-';
                array[downRow][col] = 'S';
            }
            else
            {
                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{downRow},{col}]");
                Environment.Exit(0);
            }
        }
        public static int[] FindIndexes(char[][]array, char symbol)
        {
            int[] rowAmdCol= new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j]==symbol)
                    {
                        rowAmdCol[0] = i;
                        rowAmdCol[1] = j;
                    }
                }
            }
            return rowAmdCol;
        }
        public static char[][] ReadArray(int n)
        {
            char[][] array = new char[n][];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                string input = Console.ReadLine();
                array[i] = input.ToCharArray();
            }
            return array;
        }
        public static void PrintArray(char[][] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine(string.Join("", array[i]));
            }
        }
    }
}
