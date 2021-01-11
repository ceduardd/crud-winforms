using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class BookReturn
    {
        private BookLoan bookLoan;
        private DateTime date;

        public BookReturn(BookLoan bookLoan)
        {
            this.bookLoan = bookLoan;
            date = DateTime.Now;
        }

        internal BookLoan BookLoan { get => bookLoan; set => bookLoan = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
