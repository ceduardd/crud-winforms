using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
    public class AuthorController // = AdmAutor
    {
        // Author list
        private List<Author> authors;
        private static AuthorController authorController;

        internal List<Author> Authors { get => authors; set => authors = value; }

        private AuthorController()
        {
            authors = new List<Author>();

            // Fix data to test
            authors.Add(new Author("Eduardo Chávez", "0943984765" ,"eduardo@example.com", new DateTime(1999, 12, 14), "Programación"));
            authors.Add(new Author("Jhon Doe", "0915448310", "jhon@example.com", new DateTime(2000, 1, 4), "Literatura"));
            authors.Add(new Author("Jane Doe", "0927908111", "jane@example.com", new DateTime(1997, 11, 23), "Matemática"));
        }

        // Singleton pattern
        public static AuthorController GetInstance()
        {
            if (authorController == null)
            {
                authorController = new AuthorController();
            }

            return authorController;
        }

        public bool AlreadyExist(string cedula) => authors.Exists(author => author.Cedula == cedula);

        public string Register(string name, string cedula, string email, DateTime birthdate, string category)
        {
            Author author = new Author(name, cedula, email, birthdate, category);
            authors.Add(author);

            // Return new register author info
            return author.ToString();
        }

        public int Count() => authors.Count();

        private Author GetAuthorByCedula(string cedula) => authors.Find(author => author.Cedula == cedula);

        public int GetIndexOf(string cedula)
        {
            Author authorFound = GetAuthorByCedula(cedula);

            return authors.IndexOf(authorFound);
        }

        public void Update(int index, string name, string cedula, string email, DateTime birthdate, string category)
        {
            Author author = new Author(name, cedula, email, birthdate, category);
            authors.RemoveAt(index);
            authors.Insert(index, author);
        }

        internal List<Author> AdvancedFilter(string name, string cedula, string category)
        {
            if (category == "Todas")
            {
                return authors.FindAll(author => author.Cedula.StartsWith(cedula) && author.Name.StartsWith(name));
            } else
            {
                return authors.FindAll(
                    author => author.Category == category && author.Cedula.StartsWith(cedula) && author.Name.StartsWith(name)
                );
            }
        }
    }
}
