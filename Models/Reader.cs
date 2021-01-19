using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Reader : Person
    {
        private List<BookLoan> bookLoans;

        public Reader(string name, string cedula, string email, DateTime birthdate) : base(name, cedula, email, birthdate)
        {
            bookLoans = null;
        }

        internal List<BookLoan> BookLoans { get => bookLoans; set => bookLoans = value; }
    }
}
