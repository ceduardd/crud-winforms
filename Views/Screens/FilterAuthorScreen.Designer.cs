
namespace Views.Screens
{
    partial class FilterAuthorScreen
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
            this.resultsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cedulaInput = new System.Windows.Forms.TextBox();
            this.cedulaLabel = new System.Windows.Forms.Label();
            this.rbtnFiltrar = new System.Windows.Forms.RadioButton();
            this.rbtnTodos = new System.Windows.Forms.RadioButton();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.authorListGrid = new System.Windows.Forms.DataGridView();
            this.numCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryInput = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.authorListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(126)))), ((int)(((byte)(212)))));
            this.resultsLabel.Location = new System.Drawing.Point(254, 466);
            this.resultsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(15, 16);
            this.resultsLabel.TabIndex = 20;
            this.resultsLabel.Text = "_";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(126)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(166, 466);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Resultados:";
            // 
            // cedulaInput
            // 
            this.cedulaInput.Enabled = false;
            this.cedulaInput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulaInput.Location = new System.Drawing.Point(96, 145);
            this.cedulaInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cedulaInput.MaxLength = 10;
            this.cedulaInput.Name = "cedulaInput";
            this.cedulaInput.Size = new System.Drawing.Size(244, 22);
            this.cedulaInput.TabIndex = 18;
            this.cedulaInput.TextChanged += new System.EventHandler(this.ApplyAdvancedFilter);
            this.cedulaInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cedulaInput_KeyPress);
            // 
            // cedulaLabel
            // 
            this.cedulaLabel.AutoSize = true;
            this.cedulaLabel.Enabled = false;
            this.cedulaLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(126)))), ((int)(((byte)(212)))));
            this.cedulaLabel.Location = new System.Drawing.Point(32, 148);
            this.cedulaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cedulaLabel.Name = "cedulaLabel";
            this.cedulaLabel.Size = new System.Drawing.Size(57, 16);
            this.cedulaLabel.TabIndex = 17;
            this.cedulaLabel.Text = "Cédula:";
            // 
            // rbtnFiltrar
            // 
            this.rbtnFiltrar.AutoSize = true;
            this.rbtnFiltrar.Location = new System.Drawing.Point(30, 104);
            this.rbtnFiltrar.Name = "rbtnFiltrar";
            this.rbtnFiltrar.Size = new System.Drawing.Size(97, 17);
            this.rbtnFiltrar.TabIndex = 16;
            this.rbtnFiltrar.TabStop = true;
            this.rbtnFiltrar.Text = "Filtro avanzado";
            this.rbtnFiltrar.UseVisualStyleBackColor = true;
            this.rbtnFiltrar.CheckedChanged += new System.EventHandler(this.ActivateFilterInputs);
            // 
            // rbtnTodos
            // 
            this.rbtnTodos.AutoSize = true;
            this.rbtnTodos.Location = new System.Drawing.Point(30, 76);
            this.rbtnTodos.Name = "rbtnTodos";
            this.rbtnTodos.Size = new System.Drawing.Size(55, 17);
            this.rbtnTodos.TabIndex = 15;
            this.rbtnTodos.TabStop = true;
            this.rbtnTodos.Text = "Todos";
            this.rbtnTodos.UseVisualStyleBackColor = true;
            this.rbtnTodos.CheckedChanged += new System.EventHandler(this.ActivateAllFilter);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(126)))), ((int)(((byte)(212)))));
            this.totalLabel.Location = new System.Drawing.Point(125, 466);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(15, 16);
            this.totalLabel.TabIndex = 14;
            this.totalLabel.Text = "_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(126)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(27, 466);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total autores:";
            // 
            // authorListGrid
            // 
            this.authorListGrid.AllowUserToAddRows = false;
            this.authorListGrid.AllowUserToDeleteRows = false;
            this.authorListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numCol,
            this.nameCol,
            this.cedulaCol,
            this.emailCol,
            this.birthdateCol,
            this.categoryCol});
            this.authorListGrid.Location = new System.Drawing.Point(30, 236);
            this.authorListGrid.Name = "authorListGrid";
            this.authorListGrid.ReadOnly = true;
            this.authorListGrid.Size = new System.Drawing.Size(644, 203);
            this.authorListGrid.TabIndex = 12;
            // 
            // numCol
            // 
            this.numCol.HeaderText = "N°";
            this.numCol.Name = "numCol";
            this.numCol.ReadOnly = true;
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Nombre";
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            // 
            // cedulaCol
            // 
            this.cedulaCol.HeaderText = "Cédula";
            this.cedulaCol.Name = "cedulaCol";
            this.cedulaCol.ReadOnly = true;
            // 
            // emailCol
            // 
            this.emailCol.HeaderText = "Email";
            this.emailCol.Name = "emailCol";
            this.emailCol.ReadOnly = true;
            // 
            // birthdateCol
            // 
            this.birthdateCol.HeaderText = "Fech. Nacimiento";
            this.birthdateCol.Name = "birthdateCol";
            this.birthdateCol.ReadOnly = true;
            // 
            // categoryCol
            // 
            this.categoryCol.HeaderText = "Categoría";
            this.categoryCol.Name = "categoryCol";
            this.categoryCol.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(232, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "FILTRAR AUTORES";
            // 
            // nameInput
            // 
            this.nameInput.Enabled = false;
            this.nameInput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(96, 182);
            this.nameInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nameInput.MaxLength = 10;
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(244, 22);
            this.nameInput.TabIndex = 22;
            this.nameInput.TextChanged += new System.EventHandler(this.ApplyAdvancedFilter);
            this.nameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameInput_KeyPress);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Enabled = false;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(126)))), ((int)(((byte)(212)))));
            this.nameLabel.Location = new System.Drawing.Point(32, 185);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 16);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "Nombre:";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Enabled = false;
            this.categoryLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(126)))), ((int)(((byte)(212)))));
            this.categoryLabel.Location = new System.Drawing.Point(358, 148);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(70, 16);
            this.categoryLabel.TabIndex = 23;
            this.categoryLabel.Text = "Categoría";
            // 
            // categoryInput
            // 
            this.categoryInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryInput.Enabled = false;
            this.categoryInput.FormattingEnabled = true;
            this.categoryInput.Items.AddRange(new object[] {
            "Todas",
            "Literatura",
            "Matemática",
            "Programación",
            "Historia",
            "Comedia",
            "Romance"});
            this.categoryInput.Location = new System.Drawing.Point(430, 145);
            this.categoryInput.Name = "categoryInput";
            this.categoryInput.Size = new System.Drawing.Size(244, 21);
            this.categoryInput.TabIndex = 24;
            this.categoryInput.TextChanged += new System.EventHandler(this.ApplyAdvancedFilter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(548, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Wilmer Chávez SOF-S-MA-5-1";
            // 
            // FilterAuthorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 499);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.categoryInput);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cedulaInput);
            this.Controls.Add(this.cedulaLabel);
            this.Controls.Add(this.rbtnFiltrar);
            this.Controls.Add(this.rbtnTodos);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.authorListGrid);
            this.Controls.Add(this.label1);
            this.Name = "FilterAuthorScreen";
            this.Text = "Filtrar autores";
            ((System.ComponentModel.ISupportInitialize)(this.authorListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cedulaInput;
        private System.Windows.Forms.Label cedulaLabel;
        private System.Windows.Forms.RadioButton rbtnFiltrar;
        private System.Windows.Forms.RadioButton rbtnTodos;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView authorListGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryInput;
        private System.Windows.Forms.Label label7;
    }
}