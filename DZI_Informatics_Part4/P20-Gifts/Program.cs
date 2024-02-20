namespace P20_Gifts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 0;

            int[] gifts = new int[n * 2];
            GiftStoring(n, gifts);
            int index = 0;
            while (gifts.Contains(1))
            {

            }
            
        }

        private static void GiftStoring(int n, int[] gifts)
        {
            for (int i = 0; i < n; i++)
            {
                gifts[i] = 0;
            }
            for (int i = n; i < n * 2; i++)
            {
                gifts[i] = 1;
            }
            Console.WriteLine(string.Join(" ", gifts));
        }
    }
}
