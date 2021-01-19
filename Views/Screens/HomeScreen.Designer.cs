
namespace Views.Screens
{
    partial class HomeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarAutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAutorToolStripMenuItem,
            this.listarAutoresToolStripMenuItem,
            this.modificarAutorToolStripMenuItem,
            this.eliminarAutorToolStripMenuItem,
            this.filtrarAutoresToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.menuToolStripMenuItem.Text = "Menu Autor";
            // 
            // registrarAutorToolStripMenuItem
            // 
            this.registrarAutorToolStripMenuItem.Name = "registrarAutorToolStripMenuItem";
            this.registrarAutorToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.registrarAutorToolStripMenuItem.Text = "Registrar autor";
            this.registrarAutorToolStripMenuItem.Click += new System.EventHandler(this.ShowAddAuthorForm);
            // 
            // listarAutoresToolStripMenuItem
            // 
            this.listarAutoresToolStripMenuItem.Name = "listarAutoresToolStripMenuItem";
            this.listarAutoresToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.listarAutoresToolStripMenuItem.Text = "Listar autores";
            this.listarAutoresToolStripMenuItem.Click += new System.EventHandler(this.ShowAuthorListScreen);
            // 
            // modificarAutorToolStripMenuItem
            // 
            this.modificarAutorToolStripMenuItem.Name = "modificarAutorToolStripMenuItem";
            this.modificarAutorToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.modificarAutorToolStripMenuItem.Text = "Modificar autor";
            this.modificarAutorToolStripMenuItem.Click += new System.EventHandler(this.ShowEditAuthorScreen);
            // 
            // eliminarAutorToolStripMenuItem
            // 
            this.eliminarAutorToolStripMenuItem.Name = "eliminarAutorToolStripMenuItem";
            this.eliminarAutorToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.eliminarAutorToolStripMenuItem.Text = "Eliminar autor";
            this.eliminarAutorToolStripMenuItem.Click += new System.EventHandler(this.ShowDeleteAuthorScreen);
            // 
            // filtrarAutoresToolStripMenuItem
            // 
            this.filtrarAutoresToolStripMenuItem.Name = "filtrarAutoresToolStripMenuItem";
            this.filtrarAutoresToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.filtrarAutoresToolStripMenuItem.Text = "Filtrar autores";
            this.filtrarAutoresToolStripMenuItem.Click += new System.EventHandler(this.ShowFilterAuthorScreen);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(206, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 192);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wilmer Chávez SOF-S-MA-5-1";
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 255);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeScreen";
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarAutoresToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

