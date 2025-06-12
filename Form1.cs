namespace AgendaBarbearia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void botaoEntrada_Click(object sender, EventArgs e)
        {
            string emailTexto = email.Text;
            string senhaTexto = senha.Text;

            // Exemplo de validação (dps colocar no banco)
            if (email.Text == "cliente@exemplo.com" && senha.Text == "345")
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormularioADM formularioADM = new FormularioADM();
            formularioADM.Show();
            this.Hide(); // Oculta a tela principal
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var cadastro = new Cadastro();
            cadastro.Show();
            this.Hide(); // ou use this.Close() se preferir encerrar a tela de login
        }
    }
}
