﻿
namespace Views.Screens
{
    partial class DeleteAuthorScreen
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
            this.authorListGrid = new System.Windows.Forms.DataGridView();
            this.numCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cedulaInput = new System.Windows.Forms.TextBox();
            this.cedulaLabel = new System.Windows.Forms.Label();
            this.rbtnFiltrar = new System.Windows.Forms.RadioButton();
            this.rbtnTodos = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.authorListGrid)).BeginInit();
            this.SuspendLayout();
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
            this.authorListGrid.Location = new System.Drawing.Point(32, 134);
            this.authorListGrid.Name = "authorListGrid";
            this.authorListGrid.ReadOnly = true;
            this.authorListGrid.Size = new System.Drawing.Size(644, 180);
            this.authorListGrid.TabIndex = 4;
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
            this.label1.Location = new System.Drawing.Point(244, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "ELIMINAR AUTOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(562, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nota: Seleccione la fila del registro de autor que desea eliminar y presione el b" +
    "otón Eliminar";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(32, 375);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(644, 36);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.DeleteAuthorListener);
            // 
            // cedulaInput
            // 
            this.cedulaInput.Enabled = false;
            this.cedulaInput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulaInput.Location = new System.Drawing.Point(432, 94);
            this.cedulaInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cedulaInput.MaxLength = 10;
            this.cedulaInput.Name = "cedulaInput";
            this.cedulaInput.Size = new System.Drawing.Size(244, 22);
            this.cedulaInput.TabIndex = 16;
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
            this.cedulaLabel.Location = new System.Drawing.Point(371, 97);
            this.cedulaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cedulaLabel.Name = "cedulaLabel";
            this.cedulaLabel.Size = new System.Drawing.Size(57, 16);
            this.cedulaLabel.TabIndex = 15;
            this.cedulaLabel.Text = "Cédula:";
            this.cedulaLabel.Visible = false;
            // 
            // rbtnFiltrar
            // 
            this.rbtnFiltrar.AutoSize = true;
            this.rbtnFiltrar.Location = new System.Drawing.Point(32, 99);
            this.rbtnFiltrar.Name = "rbtnFiltrar";
            this.rbtnFiltrar.Size = new System.Drawing.Size(103, 17);
            this.rbtnFiltrar.TabIndex = 14;
            this.rbtnFiltrar.TabStop = true;
            this.rbtnFiltrar.Text = "Filtrar por cedula";
            this.rbtnFiltrar.UseVisualStyleBackColor = true;
            this.rbtnFiltrar.CheckedChanged += new System.EventHandler(this.ActivateCedulaInput);
            // 
            // rbtnTodos
            // 
            this.rbtnTodos.AutoSize = true;
            this.rbtnTodos.Location = new System.Drawing.Point(32, 71);
            this.rbtnTodos.Name = "rbtnTodos";
            this.rbtnTodos.Size = new System.Drawing.Size(55, 17);
            this.rbtnTodos.TabIndex = 13;
            this.rbtnTodos.TabStop = true;
            this.rbtnTodos.Text = "Todos";
            this.rbtnTodos.UseVisualStyleBackColor = true;
            this.rbtnTodos.CheckedChanged += new System.EventHandler(this.ActivateAllFilter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(557, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Wilmer Chávez SOF-S-MA-5-1";
            // 
            // DeleteAuthorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 436);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cedulaInput);
            this.Controls.Add(this.cedulaLabel);
            this.Controls.Add(this.rbtnFiltrar);
            this.Controls.Add(this.rbtnTodos);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.authorListGrid);
            this.Controls.Add(this.label1);
            this.Name = "DeleteAuthorScreen";
            this.Text = "Eliminar autor";
            ((System.ComponentModel.ISupportInitialize)(this.authorListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView authorListGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox cedulaInput;
        private System.Windows.Forms.Label cedulaLabel;
        private System.Windows.Forms.RadioButton rbtnFiltrar;
        private System.Windows.Forms.RadioButton rbtnTodos;
        private System.Windows.Forms.Label label7;
    }
}