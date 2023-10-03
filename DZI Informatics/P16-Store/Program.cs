using System;
using System.Linq;

namespace P16_Store
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                ItemList list = new ItemList();
                for (int i = 0; i < n; i++)
                {
                    string[] data = Console.ReadLine().Split(' ').ToArray();
                    Item item = new Item(data[0], double.Parse(data[1]));
                    list.Add(item);
                }
                for (int i = 0; i < list.Size; i++)
                {
                    string info = list.Get(i).ToString();
                    Console.WriteLine(info);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         
        }
    }
}
