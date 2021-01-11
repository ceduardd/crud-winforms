using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Librarian : Person
    {
        private DateTime entryTime;
        private DateTime departureTime;

        public Librarian(string name, string cedula, string email, DateTime birthdate, DateTime entryTime, DateTime departureTime) : base(name, cedula, email, birthdate)
        {
            this.entryTime = entryTime;
            this.departureTime = departureTime;
        }

        public DateTime EntryTime { get => entryTime; set => entryTime = value; }
        public DateTime DepartureTime { get => departureTime; set => departureTime = value; }
    }
}
