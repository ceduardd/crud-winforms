using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;

namespace Views.Screens
{
    public partial class DeleteAuthorScreen : Form
    {
        UIController uiController = UIController.GetInstance();
        AuthorController authorController = AuthorController.GetInstance();

        public DeleteAuthorScreen()
        {
            InitializeComponent();

            rbtnTodos.Checked = true;

            /*if (authorController.Count() == 0)
            {
                btnDelete.Enabled = false;
            }*/
        }

        private void DeleteAuthorListener(object sender, EventArgs e)
        {
            int authorsOnGrid = authorListGrid.Rows.Count;

            if (authorController.Count() > 0 && authorsOnGrid > 0)
            {
                int index = authorListGrid.CurrentRow.Index;

                uiController.DeleteAuthorFromGrid(index, authorListGrid);
                rbtnTodos.Checked = true;
            }
            else
            {
                MessageBox.Show("No hay registros de autores");
            }
        }

        private void ActivateCedulaInput(object sender, EventArgs e)
        {
            // Toogle activate form group
            cedulaLabel.Enabled = !cedulaLabel.Enabled;
            cedulaInput.Enabled = !cedulaInput.Enabled;

            cedulaLabel.Visible = !cedulaLabel.Visible;
            cedulaInput.Visible = !cedulaInput.Visible;

            cedulaInput.Clear();
        }

        private void ActivateAllFilter(object sender, EventArgs e)
        {
            // Load authors info
            authorListGrid.Rows.Clear();
            uiController.ShowAuthorsOnGrid(authorListGrid);
        }

        private void ApplyCedulaFilter(object sender, EventArgs e)
        {
            authorListGrid.Rows.Clear();

            string cedula = cedulaInput.Text.Trim();

            uiController.ApplyCedulaFilterOnGrid(cedula, authorListGrid);
        }

        private void cedulaInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only numbers
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
