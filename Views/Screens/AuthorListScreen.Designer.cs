
namespace Views.Screens
{
    partial class AuthorListScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.authorListGrid = new System.Windows.Forms.DataGridView();
            this.numCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.rbtnTodos = new System.Windows.Forms.RadioButton();
            this.rbtnFiltrar = new System.Windows.Forms.RadioButton();
            this.cedulaInput = new System.Windows.Forms.TextBox();
            this.cedulaLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.authorListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(141, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTA DE AUTORES REGISTRADOS";
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
            this.authorListGrid.Location = new System.Drawing.Point(31, 151);
            this.authorListGrid.Name = "authorListGrid";
            this.authorListGrid.ReadOnly = true;
            this.authorListGrid.Size = new System.Drawing.Size(644, 201);
            this.authorListGrid.TabIndex = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(126)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(28, 368);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total autores:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(126)))), ((int)(((byte)(212)))));
            this.totalLabel.Location = new System.Drawing.Point(126, 368);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(15, 16);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "_";
            // 
            // rbtnTodos
            // 
            this.rbtnTodos.AutoSize = true;
            this.rbtnTodos.Location = new System.Drawing.Point(31, 80);
            this.rbtnTodos.Name = "rbtnTodos";
            this.rbtnTodos.Size = new System.Drawing.Size(55, 17);
            this.rbtnTodos.TabIndex = 5;
            this.rbtnTodos.TabStop = true;
            this.rbtnTodos.Text = "Todos";
            this.rbtnTodos.UseVisualStyleBackColor = true;
            this.rbtnTodos.CheckedChanged += new System.EventHandler(this.ActivateAllFilter);
            // 
            // rbtnFiltrar
            // 
            this.rbtnFiltrar.AutoSize = true;
            this.rbtnFiltrar.Location = new System.Drawing.Point(31, 108);
            this.rbtnFiltrar.Name = "rbtnFiltrar";
            this.rbtnFiltrar.Size = new System.Drawing.Size(103, 17);
            this.rbtnFiltrar.TabIndex = 6;
            this.rbtnFiltrar.TabStop = true;
            this.rbtnFiltrar.Text = "Filtrar por cedula";
            this.rbtnFiltrar.UseVisualStyleBackColor = true;
            this.rbtnFiltrar.CheckedChanged += new System.EventHandler(this.ActivateCedulaInput);
            // 
            // cedulaInput
            // 
            this.cedulaInput.Enabled = false;
            this.cedulaInput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulaInput.Location = new System.Drawing.Point(431, 103);
            this.cedulaInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cedulaInput.MaxLength = 10;
            this.cedulaInput.Name = "cedulaInput";
            this.cedulaInput.Size = new System.Drawing.Size(244, 22);
            this.cedulaInput.TabIndex = 8;
            this.cedulaInput.Visible = false;
            this.cedulaInput.TextChanged += new System.EventHandler(this.ApplyCedulaFilter);
            this.cedulaInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cedulaInput_KeyPress);
            // 
            // cedulaLabel
            // 
            this.cedulaLabel.AutoSize = true;
            this.cedulaLabel.Enabled = false;
            this.cedulaLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(126)))), ((int)(((byte)(212)))));
            this.cedulaLabel.Location = new System.Drawing.Point(370, 106);
            this.cedulaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cedulaLabel.Name = "cedulaLabel";
            this.cedulaLabel.Size = new System.Drawing.Size(57, 16);
            this.cedulaLabel.TabIndex = 7;
            this.cedulaLabel.Text = "Cédula:";
            this.cedulaLabel.Visible = false;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(126)))), ((int)(((byte)(212)))));
            this.resultsLabel.Location = new System.Drawing.Point(255, 368);
            this.resultsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(15, 16);
            this.resultsLabel.TabIndex = 10;
            this.resultsLabel.Text = "_";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(126)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(167, 368);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resultados:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Wilmer Chávez SOF-S-MA-5-1";
            // 
            // AuthorListScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 409);
            this.Controls.Add(this.label7);
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
            this.Name = "AuthorListScreen";
            this.Text = "Lista de autores";
            ((System.ComponentModel.ISupportInitialize)(this.authorListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView authorListGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCol;
        private System.Windows.Forms.RadioButton rbtnTodos;
        private System.Windows.Forms.RadioButton rbtnFiltrar;
        private System.Windows.Forms.TextBox cedulaInput;
        private System.Windows.Forms.Label cedulaLabel;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}