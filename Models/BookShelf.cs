using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class BookShelf
    {
        private string location;
        private List<Book> books;

        public BookShelf(string location)
        {
            this.location = location;
            this.books = null;
        }

        public string Location { get => location; set => location = value; }
        internal List<Book> Books { get => books; set => books = value; }
    }
}
