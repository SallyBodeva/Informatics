namespace P07_zad27_DZI_20._05._2022_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 51, 91 };
            List<int> newNums = DividedByK(nums, 3);
            Console.WriteLine(string.Join(" ",newNums));
        }
        public static List<int> DividedByK(List<int> list, int k)
        {
            List<int> noNeededNums = new List<int>();
            foreach (var item in list)
            {
                int sum = 0;
                int num = item;
                while (num > 0)
                {

                    int digit = num % 10;
                    sum += digit;
                    num /= 10;

                }
                if (sum % k == 0)
                {
                    noNeededNums.Add(item);
                }
            }
            foreach (var item in noNeededNums)
            {
                if (list.Contains(item))
                {
                    list.Remove(item);
                }
            }
            return list;
        }

    }
}
