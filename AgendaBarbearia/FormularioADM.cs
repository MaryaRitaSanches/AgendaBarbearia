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
            string emailTexto = email.Text;
            string senhaTexto = senha.Text;

            // Exemplo de validação simples (você pode trocar por banco depois)
            if (email.Text == "cliente@exemplo.com" && senha.Text == "123")
            {
                FormAgendamento formAgendamento = new FormAgendamento();
                formAgendamento.Show();  // Abre a tela de agendamento
                this.Hide();             // Esconde a tela de login
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
