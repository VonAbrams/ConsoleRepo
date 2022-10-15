using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsole
{
    public struct Item
    {
        public string? itemName { get; set; }

        public Item(string name)
        {
            itemName = name;
        }
    }

    public delegate void ItemCallBack(ItemCallBack itemCallBack);
    public class ItemDB
    {
        public List<Item> itemList = new List<Item>();

        public void AddItem(string itemName)
        {
            itemList.Add(new Item(itemName));
        }
        public void ItemCallBack(ItemCallBack itemCallBack)
        {
            foreach (var item in itemList)
            {
                System.Console.WriteLine(itemCallBack);
            }
        }
    }
}