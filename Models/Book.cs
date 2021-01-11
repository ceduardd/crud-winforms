using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Book
    {
        private string name;
        private Author author;
        private int edition;
        private string isbn;
        private string description;
        private string lang;
        private int qty;
        private double price;
        private BookShelf bookShelf;

        public Book(string name, Author author, int edition, string isbn, string description, string lang, int qty, double price, BookShelf bookShelf)
        {
            this.name = name;
            this.author = author;
            this.edition = edition;
            this.isbn = isbn;
            this.description = description;
            this.lang = lang;
            this.qty = qty;
            this.price = price;
            this.bookShelf = bookShelf;
        }

        public string Name { get => name; set => name = value; }
        public Author Author { get => author; set => author = value; }
        public int Edition { get => edition; set => edition = value; }
        public string ISBN { get => isbn; set => isbn = value; }
        public string Description { get => description; set => description = value; }
        public string Lang { get => lang; set => lang = value; }
        public int Qty { get => qty; set => qty = value; }
        public double Price { get => price; set => price = value; }
        internal BookShelf BookShelf { get => bookShelf; set => bookShelf = value; }
    }
}
