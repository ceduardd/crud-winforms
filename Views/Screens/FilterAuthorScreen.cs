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
    public partial class FilterAuthorScreen : Form
    {
        UIController uiController = UIController.GetInstance();
        AuthorController authorController = AuthorController.GetInstance();

        public FilterAuthorScreen()
        {
            InitializeComponent();

            // Set default filter
            rbtnTodos.Checked = true;
        }

        private void ActivateFilterInputs(object sender, EventArgs e)
        {
            // Toogle activate form group
            cedulaLabel.Enabled = !cedulaLabel.Enabled;
            cedulaInput.Enabled = !cedulaInput.Enabled;

            nameInput.Enabled = !nameInput.Enabled;
            nameLabel.Enabled = !nameLabel.Enabled;

            categoryInput.Enabled = !categoryInput.Enabled;
            categoryLabel.Enabled = !categoryLabel.Enabled;
        }

        private void ActivateAllFilter(object sender, EventArgs e)
        {
            authorListGrid.Rows.Clear();

            // Clear filter inputs toggle
            nameInput.Clear();
            cedulaInput.Clear();
            categoryInput.SelectedIndex = -1;

            uiController.ShowAuthorsOnGrid(authorListGrid);

            // Update total and results
            totalLabel.Text = $"{authorController.Count()}";
            resultsLabel.Text = $"{authorListGrid.Rows.Count}";
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

        private void nameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // A-Z, a-z, spaces, back
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != Convert.ToChar(Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void ApplyAdvancedFilter(object sender, EventArgs e)
        {
            // Get input values
            string cedula = cedulaInput.Text.Trim();
            string name = nameInput.Text.Trim();
            string category = categoryInput.Text;

            // Update with filter results
            uiController.ApplyAdvancedFiletOnGrid(authorListGrid, cedula, name, category);

            // Update total and results
            totalLabel.Text = $"{authorController.Count()}";
            resultsLabel.Text = $"{authorListGrid.Rows.Count}";
        }
    }
}
