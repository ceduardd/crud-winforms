using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Reader : Person
    {
        private List<Book> borrowedBooks;

        public Reader(string name, string cedula, string email, DateTime birthdate) : base(name, cedula, email, birthdate)
        {
            borrowedBooks = null;
        }

        internal List<Book> BorrowedBooks { get => borrowedBooks; set => borrowedBooks = value; }
    }
}
