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
    public partial class AuthorListScreen : Form
    {
        UIController uiController = UIController.GetInstance();
        AuthorController authorController = AuthorController.GetInstance();
        public AuthorListScreen()
        {
            InitializeComponent();

            rbtnTodos.Checked = true;

            
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

            totalLabel.Text = $"{authorController.Count()}";
            resultsLabel.Text = $"{authorListGrid.Rows.Count}";
        }

        private void ApplyCedulaFilter(object sender, EventArgs e)
        {
            authorListGrid.Rows.Clear();

            string cedula = cedulaInput.Text.Trim();

            uiController.ApplyCedulaFilterOnGrid(cedula, authorListGrid);

            resultsLabel.Text = Convert.ToString(authorListGrid.Rows.Count);
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
