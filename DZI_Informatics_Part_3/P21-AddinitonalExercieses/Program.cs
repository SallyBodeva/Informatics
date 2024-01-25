namespace P21_AddinitonalExerceses
{
    internal class Program
    {
        static void Main()
        {
            AverageOfGreaterThanK();
            SumOfDigit();
            Triangle();
        }

        private static void Triangle()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> rows = new List<int>();
            for (int i = n; i > 0; i--)
            {
                rows.Insert(0, i);
                Console.WriteLine(string.Join(" ", rows));
            }
        }

        private static void SumOfDigit()
        {
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        if ((i + j + k) % 2 == 0)
                        {
                            string number = $"{i}{j}{k}";
                            int n = int.Parse(number);
                            Console.WriteLine(number);
                        }
                    }
                }
            }
        }

        private static void AverageOfGreaterThanK()
        {
            int k = int.Parse(Console.ReadLine());
            List<int> nums = new List<int>();
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                if (number > k) { nums.Add(number); }
            }
            Console.WriteLine($"Average value: {nums.Average():f2}");
        }
    }
}
