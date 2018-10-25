namespace MVC
{
    partial class Form1
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
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.proteinasTextBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.ComidasList = new System.Windows.Forms.ListBox();
            this.GrasasLabel = new System.Windows.Forms.Label();
            this.CarbohidratosLabel = new System.Windows.Forms.Label();
            this.grasasTextBox = new System.Windows.Forms.TextBox();
            this.carbohidratosTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProteinasLabel = new System.Windows.Forms.Label();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(118, 23);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 0;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // proteinasTextBox
            // 
            this.proteinasTextBox.Location = new System.Drawing.Point(118, 61);
            this.proteinasTextBox.Name = "proteinasTextBox";
            this.proteinasTextBox.Size = new System.Drawing.Size(100, 20);
            this.proteinasTextBox.TabIndex = 1;
            this.proteinasTextBox.TextChanged += new System.EventHandler(this.proteinasTextBox_TextChanged);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(14, 26);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(44, 13);
            this.nombreLabel.TabIndex = 2;
            this.nombreLabel.Text = "Nombre";
            this.nombreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.Location = new System.Drawing.Point(0, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(100, 23);
            this.emailLabel.TabIndex = 10;
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Location = new System.Drawing.Point(66, 203);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(98, 27);
            this.AgregarBtn.TabIndex = 5;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComidasList
            // 
            this.ComidasList.FormattingEnabled = true;
            this.ComidasList.Location = new System.Drawing.Point(283, 12);
            this.ComidasList.Name = "ComidasList";
            this.ComidasList.Size = new System.Drawing.Size(448, 199);
            this.ComidasList.TabIndex = 5;
            this.ComidasList.SelectedIndexChanged += new System.EventHandler(this.contactosList_SelectedIndexChanged);
            // 
            // GrasasLabel
            // 
            this.GrasasLabel.AutoSize = true;
            this.GrasasLabel.Location = new System.Drawing.Point(14, 105);
            this.GrasasLabel.Name = "GrasasLabel";
            this.GrasasLabel.Size = new System.Drawing.Size(40, 13);
            this.GrasasLabel.TabIndex = 6;
            this.GrasasLabel.Text = "Grasas";
            // 
            // CarbohidratosLabel
            // 
            this.CarbohidratosLabel.AutoSize = true;
            this.CarbohidratosLabel.Location = new System.Drawing.Point(14, 148);
            this.CarbohidratosLabel.Name = "CarbohidratosLabel";
            this.CarbohidratosLabel.Size = new System.Drawing.Size(72, 13);
            this.CarbohidratosLabel.TabIndex = 7;
            this.CarbohidratosLabel.Text = "Carbohidratos";
            // 
            // grasasTextBox
            // 
            this.grasasTextBox.Location = new System.Drawing.Point(118, 102);
            this.grasasTextBox.Name = "grasasTextBox";
            this.grasasTextBox.Size = new System.Drawing.Size(100, 20);
            this.grasasTextBox.TabIndex = 2;
            // 
            // carbohidratosTextBox
            // 
            this.carbohidratosTextBox.Location = new System.Drawing.Point(118, 141);
            this.carbohidratosTextBox.Name = "carbohidratosTextBox";
            this.carbohidratosTextBox.Size = new System.Drawing.Size(100, 20);
            this.carbohidratosTextBox.TabIndex = 4;
            this.carbohidratosTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProteinasLabel);
            this.groupBox1.Controls.Add(this.carbohidratosTextBox);
            this.groupBox1.Controls.Add(this.grasasTextBox);
            this.groupBox1.Controls.Add(this.CarbohidratosLabel);
            this.groupBox1.Controls.Add(this.GrasasLabel);
            this.groupBox1.Controls.Add(this.AgregarBtn);
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.nombreLabel);
            this.groupBox1.Controls.Add(this.proteinasTextBox);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 281);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ProteinasLabel
            // 
            this.ProteinasLabel.AutoSize = true;
            this.ProteinasLabel.Location = new System.Drawing.Point(14, 68);
            this.ProteinasLabel.Name = "ProteinasLabel";
            this.ProteinasLabel.Size = new System.Drawing.Size(51, 13);
            this.ProteinasLabel.TabIndex = 11;
            this.ProteinasLabel.Text = "Proteinas";
            this.ProteinasLabel.Click += new System.EventHandler(this.ProteinasLabel_Click_1);
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Location = new System.Drawing.Point(447, 231);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(136, 33);
            this.EliminarBtn.TabIndex = 6;
            this.EliminarBtn.Text = "Eliminar Seleccion";
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 312);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComidasList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox proteinasTextBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.ListBox ComidasList;
        private System.Windows.Forms.Label GrasasLabel;
        private System.Windows.Forms.Label CarbohidratosLabel;
        private System.Windows.Forms.TextBox grasasTextBox;
        private System.Windows.Forms.TextBox carbohidratosTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ProteinasLabel;
        private System.Windows.Forms.Button EliminarBtn;
    }
}

