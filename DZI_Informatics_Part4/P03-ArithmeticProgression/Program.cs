namespace P03_ArithmeticProgression
{
    internal class Program
    {
        static void Main()
        {
            int a1 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            List<int> nums = new List<int>();
            nums.Add(a1);
            for (int i = 0; i <= n; i++)
            {
                int aEven = nums[i] + 1;
                nums.Add(aEven);
                int aOdd = nums[i] * 2;
                nums.Add(aOdd);
            }
            Console.WriteLine(nums[n-1]);
        }
    }
}
