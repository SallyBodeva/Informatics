using System;
using System.Collections.Generic;
using System.Linq;
namespace P18_Company
{
    public class Program
    {
        static void Main()
        {
            List<Item> items = new List<Item>
        {
            new Item(1, "Book", 1.99m, 10, 3),
            new Item(2, "Bike", 2.49m, 15, 2),
            new Item(3, "Guitar", 0.99m, 20, 1),
            new Item(4, "Tooth brush", 3.99m, 5, 4),
            new Item(5, "Phone", 4.79m, 8, 5),
            new Item(4, "Test", 3.99m, 5, 4),
            new Item(5, "Test1", 4.79m, 8, 4),
        };

            //OrderedByName(items);
            //items.Sort(new Compare());

            Console.WriteLine(AveragePriceType4(items));
        }

        public static void OrderedByName(List<Item> items)
        {
            foreach (var item in items.OrderBy(x => x.Name))
            {
                string uniqueCode = (item.Id + item.Name[0].ToString() + item.Name[1].ToString() + item.Type).ToString();
                Console.WriteLine($"{item.Id}, {item.Name}, {item.Price} лв., {item.InStock}броя, {item.Type} тип, {uniqueCode}");
            }
        }
        public static string AveragePriceType4(List<Item> items)
        {
            var i = items.FirstOrDefault(x => x.Type == 4);
            if (i!=null)
            {
                return $"Average value: {items.Where(x => x.Type == 4).Average(x => x.Price):f2}, Total sum: {items.Where(x => x.Type == 4).Sum(x => x.Price):f2}";
            }
            else
            {
                return $"Items type 4 not found...";
            }
    
        }
    }
    public class Item:Compare
    {
        private string name;
        private int type;

        public Item(int id, string name, decimal price, int inStock, int type)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.InStock = inStock;
            this.Type = type;
        }

        public int Id { get; private set; }
        public string Name
        {
            get => name; set
            {
                if (value.Length < 2 || value.Length > 20)
                {
                    throw new ArgumentException("Invalid name...");
                }
                name = value;
            }
        }
        public decimal Price { get; set; } = 0.10m;
        public int InStock { get; set; }
        public int Type
        {
            get => type; set
            {
                List<int> types = new List<int>() { 1, 2, 3, 4, 5 };
                if (!types.Contains(value))
                {
                    throw new ArgumentException("Invalid type...");
                }
                type = value;
            }
        }
    }
    public class Compare : IComparer<Item>
    {
        int IComparer<Item>.Compare(Item x, Item y)
        {
            decimal sumX = x.Price * x.InStock;
            decimal sumY = y.Price * y.InStock;
            if (sumX>sumY)
            {
                return 1;
            }
            else if (sumX<sumY)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }


}
