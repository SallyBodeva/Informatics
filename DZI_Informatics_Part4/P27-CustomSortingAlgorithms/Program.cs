namespace P27_CustomSortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() {15,2,21,81,23,63,32,};

            //Console.WriteLine(string.Join(" ",nums.OrderBy(x=>SumOfDigit(x)).ThenBy(x=>x)));
            //Console.WriteLine(string.Join(" ", nums.OrderBy(x => Compare(x))));
            //Console.WriteLine(string.Join(" ",OrderByEvenOdd(nums)));

            Console.WriteLine(string.Join(" ",SpecificCustimSort(nums)));

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
        public static List<int> SwapEvenIndex(List<int> nums)
        {
            int midIndex = (0 + nums.Count - 1)/2;
            for (int i = 0; i < midIndex; i+=2)
            {
                int destinationIndex = midIndex + (midIndex - i);
                int firstNum = nums[i];
                nums[i] = nums[destinationIndex];
                nums[destinationIndex] = firstNum;
            }
            return nums;
        }
        public static List<int> SpecificCustimSort(List<int> nums)
        {
            List<int> evenNums = nums.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            List<int> divisibleBy3 =  nums.Where(x => x % 3 == 0).OrderBy(x => x).ToList();
            List<int> divisibleBy5 = nums.Where(x => x % 5 == 0).OrderBy(x => x).ToList();
            List<int> divisibleBy7 = nums.Where(x => x % 3 == 0).OrderBy(x => x).ToList();
            List<int> newList = new List<int>();
            newList.AddRange(evenNums);
            newList.AddRange(divisibleBy3);
            newList.AddRange(divisibleBy5);
            newList.AddRange(divisibleBy7);
            return newList;
        }
    }
}
