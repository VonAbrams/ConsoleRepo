using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsole
{
    public delegate void ProcessItemCallback(ProductModel productModel);
    public delegate void MentionDiscount(decimal subTotal);
    public class ShoppingCartModel
    {

        private List<ProductModel> ItemsList { get; set; } = new List<ProductModel>();

        public decimal GenerateTotal(MentionDiscount mentionDiscount)
        {
            decimal subTotal = ItemsList.Sum(x => x.Price);

            mentionDiscount(subTotal);

            if (subTotal > 100)
            {
                return subTotal * 0.80M;
            }
            else
            {
                return subTotal;
            }
        }

        public void AddItem(string itemName, decimal Price)
        {
            ItemsList.Add(new ProductModel(itemName, Price));
        }
        public void ProcessItemCallback(ProcessItemCallback callBack)
        {
            foreach (ProductModel item in ItemsList)
            {
                callBack(item);
            }
        }
    }

    public struct ProductModel
    {
        public string itemName { get; set; }
        public decimal Price { get; set; }

        public ProductModel(string iName, decimal iPrice)
        {
            itemName = iName;
            Price = iPrice;
        }
    }
}