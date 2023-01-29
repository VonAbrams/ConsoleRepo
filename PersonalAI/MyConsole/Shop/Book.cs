using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore
{
    public struct Book
    {
        public string Title;
        public string Author;
        public decimal Price;
        public bool Paperback;

        public Book(string title, string author, decimal price, bool paperBack)
        {
            Title = title;
            Author = author;
            Price = price;
            Paperback = paperBack;
        }
    }

    public delegate void ProcessBookCallBack(Book book);

    public class BookDB
    {
        List<Book> books = new List<Book>();

        public void AddBook(string title, string author, decimal price, bool paperBack)
        {
            books.Add(new Book(title, author, price, paperBack));
        }

        public void ProcessBookCallBack(ProcessBookCallBack processBook)
        {
            foreach (Book item in books)
            {
                if (item.Paperback)
                {
                    processBook(item);

                }

            }
        }
    }
}