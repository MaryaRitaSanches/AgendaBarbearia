using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AgendaBarbearia
{
    public partial class FormularioADM : Form
    {
        public FormularioADM()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormularioADM_Load(object sender, EventArgs e)
        {

        }

        private void botaoEntrada_Click(object sender, EventArgs e)
        {
            string usuario = txtBox1.Text;
            string senha = txtBox2.Text;

            // Aqui você pode colocar um login fixo, já que não tem banco ainda
            if (usuario == "admin" && senha == "1234")
            {
                MessageBox.Show("Login de barbeiro realizado!");
                var telaAgendamentos = new TelaAgendamentoForm();
                telaAgendamentos.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var cadastro = new Cadastro();
            cadastro.Show();
            this.Hide(); // ou use this.Close() se preferir encerrar a tela de login
        }
    }
}
