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
using Controllers.Helpers;

namespace Views.Forms
{
    public partial class EditAuthorForm : Form
    {
        // Refrences
        private string initialCedula;
        private string initialEamil;
        private DataGridView authorsListGridRef;
        private RadioButton rbtnTodosRef;

        UIController uiController = UIController.GetInstance();
        AuthorController authorController = AuthorController.GetInstance();
        public EditAuthorForm(string name, string cedula, string email, DateTime birthdate, string category, DataGridView authorsListGridRef, RadioButton rbtnTodosRef)
        {
            InitializeComponent();

            nameInput.Text = name;
            cedulaInput.Text = cedula;
            emailInput.Text = email;
            birthdateInput.Value = birthdate;
            categoryInput.SelectedIndex = categoryInput.Items.IndexOf(category);

            // Keep value before apply changes
            initialCedula = cedula;
            initialEamil = email;
            this.authorsListGridRef = authorsListGridRef;
            this.rbtnTodosRef = rbtnTodosRef;
        }

        private void UpdateAuthorListener(object sender, EventArgs e)
        {
            string name = nameInput.Text.Trim();
            string cedula = cedulaInput.Text.Trim();
            string email = emailInput.Text.Trim();
            DateTime birthdate = birthdateInput.Value;
            string category = categoryInput.Text.Trim();

            if (initialCedula != cedula)
            {
                if (!Validator.IsValidCedula(cedula))
                {
                    MessageBox.Show($"La cédula { cedula } no es correcta, debe contener 10 caracteres");
                    return;
                }

                if (authorController.AlreadyExist(cedula))
                {
                    MessageBox.Show($"La cédula { cedula } ya se encuentra registrada");
                    return;
                }
            }

            if (initialEamil != email)
            {
                if (!Validator.IsValidEmail(email))
                {
                    MessageBox.Show($"El email { email } es inválido");
                    return;
                }
            }

            if (Validator.AnyFieldIsEmpty(name, cedula, email, birthdate, category))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            // Get index of author list
            int index = authorController.GetIndexOf(initialCedula);

            // Call to controller
            authorController.Update(index, name, cedula, email, birthdate, category);
            MessageBox.Show("Registro actualizado");

            OnUpdate();
        }

        private void OnUpdate()
        {
            this.Close();
            authorsListGridRef.Rows.Clear();
            uiController.ShowAuthorsOnGrid(authorsListGridRef);
            rbtnTodosRef.Checked = true;
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
