using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers.Helpers;
using Controllers;

namespace Views.Forms
{
    public partial class AddAuthorForm : Form
    {
        AuthorController authorController = AuthorController.GetInstance();
        public AddAuthorForm()
        {
            InitializeComponent();
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

        private void AddAuthorListener(object sender, EventArgs e)
        {
            string name = nameInput.Text.Trim();
            string cedula = cedulaInput.Text.Trim();
            string email = emailInput.Text.Trim();
            DateTime birthdate = birthdateInput.Value;
            string category = categoryInput.Text.Trim();

            if (Validator.AnyFieldIsEmpty(name, cedula, email, birthdate, category))
            {
                MessageBox.Show("Todos los campos son obligatorios");
            } else if (!Validator.IsValidEmail(email))
            {
                MessageBox.Show($"El email { email } es inválido");
            }
            else if (!Validator.IsValidCedula(cedula))
            {
                MessageBox.Show($"La cédula { cedula } no es correcta, debe contener 10 caracteres");
            } else if (authorController.AlreadyExist(cedula)) {
                MessageBox.Show($"La cédula { cedula } ya se encuentra registrada");
            }
            else
            {
                // Register author
                string registerInfo = authorController.Register(name, cedula, email, birthdate, category);
                // MessageBox.Show(registerInfo, "Autor Registrado");
                MessageBox.Show(registerInfo, "Autor Registardo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
