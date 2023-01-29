using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyConsole;
namespace ItemStore
{
    public struct Item
    {
        public static int itemCount = 0;
        public string? itemName { get; set; }
        public decimal itemPrice { get; set; }
        public Item(string name, decimal price)
        {
            itemCount += 1;
            itemName = name;
            itemPrice = price;

        }


    }

    public delegate void ItemCallBack(Item item);
    public class ItemDB : IDiscount
    {
        public List<Item> itemList = new List<Item>();

        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int TotalDownloadsLeft { get; private set; } = 5;

        public bool HasOrderBeenCompleted => throw new NotImplementedException();

        public delegate void StoreDiscount(decimal subTotal);

        public void AddItem(string itemName, decimal price)
        {
            itemList.Add(new Item(itemName, price));
        }
        public void ItemCallBack(ItemCallBack itemCallBack)
        {
            foreach (var item in itemList)
            {
                itemCallBack(item);
            }
        }

        public decimal GenerateTotal(StoreDiscount storeDiscount, Func<List<Item>, decimal, decimal> calculateDiscountedTotal, Action<string> DiscountMessage)
        {
            decimal subTotal = itemList.Sum(x => x.itemPrice);

            storeDiscount(subTotal);

            DiscountMessage("Applying the discount");

            return calculateDiscountedTotal(itemList, subTotal);
        }

        public void IsDiscounted()
        {
            throw new NotImplementedException();
        }

        public void ShipItem(Item item)
        {
            if (HasOrderBeenCompleted == false)
            {
                System.Console.WriteLine($"Sending emailing {Title}");
            }
        }
    }
}