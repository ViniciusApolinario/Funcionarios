namespace WindowsFormsApplication1
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
            this.Txnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdadeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Cpfbox = new System.Windows.Forms.TextBox();
            this.ProfissaoBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SalarioBox = new System.Windows.Forms.TextBox();
            this.Enviar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TelefoneBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SonBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EnderecoBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SangueBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Txnome
            // 
            this.Txnome.Location = new System.Drawing.Point(121, 49);
            this.Txnome.Name = "Txnome";
            this.Txnome.Size = new System.Drawing.Size(305, 20);
            this.Txnome.TabIndex = 0;
            this.Txnome.TextChanged += new System.EventHandler(this.Txnome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Completo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Idade :";
            // 
            // IdadeBox
            // 
            this.IdadeBox.Location = new System.Drawing.Point(73, 86);
            this.IdadeBox.Name = "IdadeBox";
            this.IdadeBox.Size = new System.Drawing.Size(46, 20);
            this.IdadeBox.TabIndex = 3;
            this.IdadeBox.TextChanged += new System.EventHandler(this.IdadeBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(70, 128);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(35, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "M";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(111, 128);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(32, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "F";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Cpfbox
            // 
            this.Cpfbox.Location = new System.Drawing.Point(190, 86);
            this.Cpfbox.Name = "Cpfbox";
            this.Cpfbox.Size = new System.Drawing.Size(236, 20);
            this.Cpfbox.TabIndex = 8;
            this.Cpfbox.TextChanged += new System.EventHandler(this.Cpfbox_TextChanged);
            // 
            // ProfissaoBox
            // 
            this.ProfissaoBox.Location = new System.Drawing.Point(89, 157);
            this.ProfissaoBox.Name = "ProfissaoBox";
            this.ProfissaoBox.Size = new System.Drawing.Size(305, 20);
            this.ProfissaoBox.TabIndex = 10;
            this.ProfissaoBox.TextChanged += new System.EventHandler(this.ProfissaoBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Profissao :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Salário :";
            // 
            // SalarioBox
            // 
            this.SalarioBox.Location = new System.Drawing.Point(89, 268);
            this.SalarioBox.Name = "SalarioBox";
            this.SalarioBox.Size = new System.Drawing.Size(65, 20);
            this.SalarioBox.TabIndex = 13;
            this.SalarioBox.TextChanged += new System.EventHandler(this.SalarioBox_TextChanged);
            // 
            // Enviar
            // 
            this.Enviar.Location = new System.Drawing.Point(232, 301);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(127, 86);
            this.Enviar.TabIndex = 16;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Formulario de Trabalho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email:";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(89, 183);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(305, 20);
            this.EmailBox.TabIndex = 18;
            this.EmailBox.TextChanged += new System.EventHandler(this.EmailBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Telefone:";
            // 
            // TelefoneBox
            // 
            this.TelefoneBox.Location = new System.Drawing.Point(89, 209);
            this.TelefoneBox.Name = "TelefoneBox";
            this.TelefoneBox.Size = new System.Drawing.Size(305, 20);
            this.TelefoneBox.TabIndex = 20;
            this.TelefoneBox.TextChanged += new System.EventHandler(this.TelefoneBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(162, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Nº de filhos:";
            // 
            // SonBox
            // 
            this.SonBox.Location = new System.Drawing.Point(232, 126);
            this.SonBox.Name = "SonBox";
            this.SonBox.Size = new System.Drawing.Size(79, 20);
            this.SonBox.TabIndex = 23;
            this.SonBox.TextChanged += new System.EventHandler(this.SonBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Endereço";
            // 
            // EnderecoBox
            // 
            this.EnderecoBox.Location = new System.Drawing.Point(89, 235);
            this.EnderecoBox.Name = "EnderecoBox";
            this.EnderecoBox.Size = new System.Drawing.Size(305, 20);
            this.EnderecoBox.TabIndex = 24;
            this.EnderecoBox.TextChanged += new System.EventHandler(this.EnderecoBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Sexo :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tipo Sanguineo :";
            // 
            // SangueBox
            // 
            this.SangueBox.FormattingEnabled = true;
            this.SangueBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.SangueBox.Location = new System.Drawing.Point(121, 304);
            this.SangueBox.Name = "SangueBox";
            this.SangueBox.Size = new System.Drawing.Size(79, 21);
            this.SangueBox.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 410);
            this.Controls.Add(this.SangueBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.EnderecoBox);
            this.Controls.Add(this.SonBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TelefoneBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.SalarioBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProfissaoBox);
            this.Controls.Add(this.Cpfbox);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdadeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txnome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdadeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox Cpfbox;
        private System.Windows.Forms.TextBox ProfissaoBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SalarioBox;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TelefoneBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SonBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EnderecoBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox SangueBox;
    }
}

