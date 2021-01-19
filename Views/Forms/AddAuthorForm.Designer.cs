
namespace Views.Forms
{
    partial class AddAuthorForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.cedulaInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.birthdateInput = new System.Windows.Forms.DateTimePicker();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.categoryInput = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(187, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRAR AUTOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(126)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(51, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(51, 109);
            this.nameInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nameInput.MaxLength = 50;
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(244, 22);
            this.nameInput.TabIndex = 2;
            this.nameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameInput_KeyPress);
            // 
            // cedulaInput
            // 
            this.cedulaInput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulaInput.Location = new System.Drawing.Point(51, 175);
            this.cedulaInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cedulaInput.MaxLength = 10;
            this.cedulaInput.Name = "cedulaInput";
            this.cedulaInput.Size = new System.Drawing.Size(244, 22);
            this.cedulaInput.TabIndex = 4;
            this.cedulaInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cedulaInput_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(126)))), ((int)(((byte)(212)))));
            this.label3.Location = new System.Drawing.Point(51, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cédula:";
            // 
            // emailInput
            // 
            this.emailInput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailInput.Location = new System.Drawing.Point(51, 241);
            this.emailInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.emailInput.MaxLength = 50;
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(244, 22);
            this.emailInput.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(126)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(51, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(126)))), ((int)(((byte)(212)))));
            this.label5.Location = new System.Drawing.Point(323, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // birthdateInput
            // 
            this.birthdateInput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdateInput.Location = new System.Drawing.Point(323, 109);
            this.birthdateInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.birthdateInput.Name = "birthdateInput";
            this.birthdateInput.Size = new System.Drawing.Size(244, 22);
            this.birthdateInput.TabIndex = 8;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(51, 305);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(516, 36);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.AddAuthorListener);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(126)))), ((int)(((byte)(212)))));
            this.label6.Location = new System.Drawing.Point(323, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Categoría:";
            // 
            // categoryInput
            // 
            this.categoryInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryInput.FormattingEnabled = true;
            this.categoryInput.Items.AddRange(new object[] {
            "Literatura",
            "Matemática",
            "Programación",
            "Historia",
            "Comedia",
            "Romance"});
            this.categoryInput.Location = new System.Drawing.Point(323, 175);
            this.categoryInput.Name = "categoryInput";
            this.categoryInput.Size = new System.Drawing.Size(244, 23);
            this.categoryInput.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Wilmer Chávez SOF-S-MA-5-1";
            // 
            // AddAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 369);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.categoryInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.birthdateInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cedulaInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AddAuthorForm";
            this.Text = "Formulario de registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cedulaInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker birthdateInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox categoryInput;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label7;
    }
}