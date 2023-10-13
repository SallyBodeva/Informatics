using System;
using System.Collections.Generic;
using System.Data;

namespace P24_HatShop
{
    public class Program
    {
        static void Main()
        {
            Dictionary<string, HatShop> shops = new Dictionary<string, HatShop>();
            while (true)
            {
                string[] data = Console.ReadLine().Split(" ");
                if (data[0] == "STOP")
                {
                    break;
                }
                string shopName = string.Empty;
                switch (data[0])
                {
                    case "CreateHatShop":
                        shopName = data[1];
                        HatShop hatShop = new HatShop(shopName);
                        shops.Add(shopName, hatShop);
                        Console.WriteLine($"You created hat shop {shopName}.");
                        break;
                    case "AddHat":
                        Hat hat = new Hat(data[1], data[2], double.Parse(data[3]));
                        shopName = data[4];
                        shops[shopName].AddHat(hat);
                        Console.WriteLine($"You added hat {hat.Type} with color {hat.Color} to shop {shopName}.");
                        break;
                    case "SellHat":
                        shopName = data[4];
                        Hat hatSell = shops[shopName].GetHat(data[1], data[2], double.Parse(data[3]));
                        shops[shopName].SellHat(hatSell);
                        Console.WriteLine($"You sold hat {hatSell.Type} with color {hatSell.Color} from hat shop {shopName}.");
                        break;
                    case "CalculateTotalPrice":
                        shopName = data[1];
                        Console.WriteLine($"Total price: {shops[shopName].CalculateTotalPrice():f2}");
                        break;
                    case "RenameHatShop":
                        shopName = data[1];
                        string newName = data[2];
                        HatShop oldValue = shops[shopName];
                        shops[shopName].RenameHatShop(newName);
                        shops.Remove(shopName);
                        shops.Add(newName, oldValue);
                        Console.WriteLine($"You renamed your shop from {shopName} to {newName}.");
                        break;
                    case "SellAllHats":
                        shopName = data[1];
                        shops[shopName].SellAllHats();
                        Console.WriteLine($"You sold all hats from shop {shopName}.");
                        break;
                    case "GetHatWithHighestPrice":
                        shopName = data[1];
                        Hat h = shops[shopName].GetHatWithHighestPrice();
                        Console.WriteLine($"Hat from shop MyNewShop has highest price: {h.Price:f2}");
                        break;
                    case "GetHatWithLowestPrice":
                        shopName = data[1];
                        Hat l = shops[shopName].GetHatWithLowestPrice();
                        Console.WriteLine($"Hat from shop MyNewShop has highest price: {l.Price:f2}");
                        break;
                    case "HatShopInfo":
                        shopName = data[1];
                        Console.WriteLine(shops[shopName].ToString());
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }
        }
    }
}