using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Controllers
{
    public class UIController // = AdmAutor ( Encargado de modificar las vistas )
    {
        private static UIController uiController;

        private UIController() { }

        public static UIController GetInstance()
        {
            if (uiController == null)
            {
                uiController = new UIController();
            }

            return uiController;
        }

        public void ShowAuthorsOnGrid(DataGridView authorListGrid)
        {
            int count = 1;

            AuthorController.GetInstance().Authors.ForEach(
                author => {
                    AddAuthorToGrid(authorListGrid, author, count++);
                }
            );
        }

        public void DeleteAuthorFromGrid(int index, DataGridView authorListGrid)
        {
            AuthorController.GetInstance().Authors.RemoveAt(index);
            authorListGrid.Rows.RemoveAt(index);

            // Clear and update grid view
            authorListGrid.Rows.Clear();
            ShowAuthorsOnGrid(authorListGrid);
        }

        public void ApplyCedulaFilterOnGrid(string cedula, DataGridView authorListGrid)
        {
            int count = 1;

            AuthorController.GetInstance().Authors.ForEach(
                author =>
                {
                    if (author.Cedula.StartsWith(cedula))
                    {
                        AddAuthorToGrid(authorListGrid, author, count++);
                    }
                }
            );
        }

        public void ApplyAdvancedFiletOnGrid(DataGridView authorListGrid, string cedula, string name, string category)
        {
            authorListGrid.Rows.Clear();

            List<Author> filterAuthors = AuthorController.GetInstance().AdvancedFilter(name, cedula, category);

            int count = 1;

            foreach (Author author in filterAuthors)
            {
                AddAuthorToGrid(authorListGrid, author, count++);
            }
        }

        private void AddAuthorToGrid(DataGridView authorListGrid, Author author, int count)
        {
            authorListGrid.Rows.Add(
                count,
                author.Name,
                author.Cedula,
                author.Email,
                author.Birthdate.ToShortDateString(),
                author.Category
            );
        }
    }
}
