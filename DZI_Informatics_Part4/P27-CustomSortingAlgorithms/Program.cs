namespace P27_CustomSortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() {13,2,19,81,23,61,32,-19,56,4};

            Console.WriteLine(string.Join(" ",nums.OrderBy(x=>SumOfDigit(x)).ThenBy(x=>x)));
            Console.WriteLine(string.Join(" ", nums.OrderBy(x => Compare(x))));
            Console.WriteLine(string.Join(" ",OrderByEvenOdd(nums)));
        }
        public static int SumOfDigit(int num)
        {
            int sum = 0;
            while (Math.Abs(num)>0)
            {
                int digit = num % 10;
                sum += digit;
                num /= 10;
            }
            return Math.Abs(sum);
        }
        public static List<int> OrderByEvenOdd(List<int> nums)
        {
            List<int> orderedNums =nums.OrderBy(x => Compare(x)).ToList();
            List<int> evenNums = orderedNums.Where(x => Math.Abs(x) % 2 == 0).OrderBy(x => x).ToList();
            List<int> oddNums = orderedNums.Where(x => Math.Abs(x) % 2 == 1).OrderByDescending(x => x).ToList();
            List<int> newList = new List<int>();
            newList.AddRange(evenNums);
            newList.AddRange(oddNums);
            return newList;
        }
        public static int Compare(int n)
        {
            if (n%2==0)
            {
                return 0;
            }
            else
            {
                return 1 ;
            }
        }
    }
}
