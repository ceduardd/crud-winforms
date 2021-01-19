using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Person
    {
        private string name;
        private string cedula;
        private string email;
        private DateTime birthdate;

        protected Person(string name, string cedula, string email, DateTime birthdate)
        {
            this.name = name;
            this.cedula = cedula;
            this.email = email;
            this.birthdate = birthdate;
        }

        public string Name { get => name; set => name = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }

        public override string ToString()
        {
            return $"Nombre: { name }" + Environment.NewLine +
                $"Cédula: { cedula }" + Environment.NewLine +
                $"Email: { email }" + Environment.NewLine +
                $"Fecha de nacimiento: { birthdate.ToShortDateString() }" + Environment.NewLine;
        }
    }
}
