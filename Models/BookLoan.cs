using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class BookLoan
    {
        private Book book;
        private Reader reader;
        private BookReturn bookReturn;
        private DateTime date;

        public BookLoan(Book book, Reader reader)
        {
            this.book = book;
            this.reader = reader;
            this.bookReturn = null;
            date = DateTime.Now;
        }

        internal Book Book { get => book; set => book = value; }
        internal Reader Reader { get => reader; set => reader = value; }
        internal BookReturn BookReturn { get => bookReturn; set => bookReturn = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
