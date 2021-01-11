using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Author : Person
    {
        private List<Book> books;

        public Author(string name, string cedula, string email, DateTime birthdate) : base(name, cedula, email, birthdate)
        {
            books = null;
        }

        internal List<Book> Books { get => books; set => books = value; }
    }
}
