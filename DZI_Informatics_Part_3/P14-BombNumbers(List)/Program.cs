namespace P14_BombNumbers_List_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> bombInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); ;
            int bomb = bombInfo[0];
            int radius = bombInfo[1];
            int bombIndex = 0;
            try
            {
                 bombIndex = nums.IndexOf(bomb);
                for (int i = 1; i <= radius; i++)
                {
                    if (bombIndex - i>=0)
                    {
                        nums.RemoveAt(bombIndex - i);
                    }
                }
                 bombIndex = nums.IndexOf(bomb);
                for (int i = 1; i <= radius; i++)
                {
                    if (bombIndex + i<=nums.Count-1)
                    {
                        nums.RemoveAt(bombIndex + i);
                    }
                }
                nums.Remove(bomb);

            }
            catch (Exception ex)
            {

            }
            Console.WriteLine(string.Join(" ",nums));
            Console.WriteLine(nums.Sum());
        }
    }
}
