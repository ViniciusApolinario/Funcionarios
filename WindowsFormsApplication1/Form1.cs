using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<Funcionario> Funcionarios = new List<Funcionario>();
        Funcionario funcionario = new Funcionario();

        public Form1()
        {
            InitializeComponent();
        }

        private void Txnome_TextChanged(object sender, EventArgs e)
        {
            funcionario.NomeCompleto = Txnome.Text;
           

        }

        private void Cpfbox_TextChanged(object sender, EventArgs e)
        {
            funcionario.CPF = Cpfbox.Text;
        }

        private void IdadeBox_TextChanged(object sender, EventArgs e)
        {
            funcionario.Idade = IdadeBox.Text;
        }


        private void SonBox_TextChanged(object sender, EventArgs e)
        {
            funcionario.NumeroDeFilhos = SonBox.Text;
        }

        private void ProfissaoBox_TextChanged(object sender, EventArgs e)
        {
            funcionario.Profissao = ProfissaoBox.Text;
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {
            funcionario.Email = EmailBox.Text;
        }

        private void TelefoneBox_TextChanged(object sender, EventArgs e)
        {
            funcionario.Telefone = TelefoneBox.Text;
        }

        private void EnderecoBox_TextChanged(object sender, EventArgs e)
        {
            funcionario.Endereco = EnderecoBox.Text;
        }

        private void SalarioBox_TextChanged(object sender, EventArgs e)
        {
            funcionario.salario = SalarioBox.Text;
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                funcionario.Genero = "Masculino";
                checkBox2.CheckState = CheckState.Unchecked;
            }
            else
            {
                funcionario.Genero = "Feminino";
            }


        }

        public void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                checkBox1.CheckState = CheckState.Unchecked;
            }
            else
            {
                funcionario.Genero = "Masculino";
            }

        }

        public void Clear()
        {
            Txnome.Text = "";
            IdadeBox.Text = "";
            Cpfbox.Text = "";
            SonBox.Text = "";
            ProfissaoBox.Text = "";
            EmailBox.Text = "";
            TelefoneBox.Text = "";
            EnderecoBox.Text = "";
            SalarioBox.Text = "";
            SangueBox.Text = "";
            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Unchecked;
            
        }

        private void SangueBox_TextChanged(object sender, EventArgs e)
        {
            funcionario.sangue = SangueBox.Text;
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            Funcionarios.Add(new Funcionario(Txnome.Text, IdadeBox.Text, Cpfbox.Text, SonBox.Text, ProfissaoBox.Text, EmailBox.Text, TelefoneBox.Text, EnderecoBox.Text, SalarioBox.Text, SangueBox.Text));
            //MessageBox.Show();
            funcionario.addInform();
            Clear();
        }

       
       
    }
}
