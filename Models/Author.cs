using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Author : Person
    {
        private string category;
        public Author(string name, string cedula, string email, DateTime birthdate, string category) : base(name, cedula, email, birthdate)
        {
            this.category = category;
        }

        public string Category { get => category; set => category = value; }

        public override string ToString()
        {
            return base.ToString() + $"Categoría: { category }" + Environment.NewLine;
        }
    }
}
