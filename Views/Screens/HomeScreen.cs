using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.Forms;

namespace Views.Screens
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void ShowAddAuthorForm(object sender, EventArgs e)
        {
            AddAuthorForm addAuthorForm = new AddAuthorForm();
            addAuthorForm.Show();
        }

        private void ShowAuthorListScreen(object sender, EventArgs e)
        {
            AuthorListScreen authorListScreen = new AuthorListScreen();
            authorListScreen.Show();
        }

        private void ShowDeleteAuthorScreen(object sender, EventArgs e)
        {
            DeleteAuthorScreen deleteAuthorScreen = new DeleteAuthorScreen();
            deleteAuthorScreen.Show();
        }

        private void ShowEditAuthorScreen(object sender, EventArgs e)
        {
            EditAuthorScreen editAuthorScreen = new EditAuthorScreen();
            editAuthorScreen.Show();
        }

        private void ShowFilterAuthorScreen(object sender, EventArgs e)
        {
            FilterAuthorScreen filterAuthorScreen = new FilterAuthorScreen();
            filterAuthorScreen.Show();
        }
    }
}
