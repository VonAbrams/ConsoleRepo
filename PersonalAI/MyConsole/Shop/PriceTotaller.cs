using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsole
{
    using ItemStore;
    using BookStore;
    class PriceTotaller
    {
        int countBooks = 0;
        int itemCount = 0;

        decimal priceBooks = 0.80M;
        decimal priceItem = 0.80M;
        internal void AddBookToTotal(Book book)
        {
            countBooks += 1;
            priceBooks += book.Price;
        }

        public decimal AveragePrice()
        {
            return priceBooks / countBooks;
        }

        internal void AddItemTotal(Item item)
        {
            itemCount += 1;
            priceItem += item.itemPrice;
        }

        public decimal AverageItemPrice()
        {
            return priceItem / itemCount;
        }
    }
}