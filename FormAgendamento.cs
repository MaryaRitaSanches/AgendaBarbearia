using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaBarbearia
{
    public partial class FormAgendamento : Form
    {
        public FormAgendamento()
        {
            InitializeComponent();
        }

            private void FormAgendamento_Load(object sender, EventArgs e)
        {
            comboHorario.Items.Clear();  // Limpa qualquer item antigo

            // Adiciona os horários disponíveis
            comboHorario.Items.Add("09:00");
            comboHorario.Items.Add("10:00");
            comboHorario.Items.Add("11:00");
            comboHorario.Items.Add("13:00");
            comboHorario.Items.Add("14:00");
            comboHorario.Items.Add("15:00");
            comboHorario.Items.Add("16:00");
            comboHorario.Items.Add("17:00");
        }

        

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            DateTime dataSelecionada = calendarioAgenda.SelectionStart;
            string horarioSelecionado = comboHorario.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(horarioSelecionado))
            {
                MessageBox.Show("Por favor, selecione um horário.");
                return;
            }

            string agendamento = $"Agendamento realizado para {dataSelecionada.ToShortDateString()} às {horarioSelecionado}.";
            MessageBox.Show(agendamento, "Sucesso");


        }

        private void comboHorario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
