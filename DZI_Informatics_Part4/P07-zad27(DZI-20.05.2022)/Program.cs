using System.Collections;

namespace P07_zad27_DZI_20._05._2022_
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете име на файл:");
            string fileName = Console.ReadLine();
            Console.Write("Въведете цяло число К:");
            int k = int.Parse(Console.ReadLine());

            List<int> list = ReadList(fileName);
            List<int> newList = DividedByK(list, k);
            OrderBySum(newList);
            Console.WriteLine(string.Join(" ",newList));


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
        public static void OrderBySum(List<int> list)
        {
            list.Sort((x,y)=>SumOfDigitd(x).CompareTo(SumOfDigitd(y)));
        }

        public static int SumOfDigitd(int x)
        {
            int sum = 0;
            while (x > 0)
            {
                int digit = x % 10;
                sum += digit;
                x /= 10;
            }
            return sum;
        }
        public static List<int> ReadList(string path)
        {
            List<int> nums = new List<int>();
            StreamReader sr = new StreamReader(path);
            using (sr)
            {
                while (true)
                {
                    string line = sr.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    nums.Add(int.Parse(line));
                }
            }
            return nums;
        }
    }
}
