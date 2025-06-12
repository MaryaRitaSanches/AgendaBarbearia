namespace AgendaBarbearia
{
    partial class FormAgendamento
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
            calendarioAgenda = new MonthCalendar();
            comboHorario = new ComboBox();
            label1 = new Label();
            btnAgendar = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // calendarioAgenda
            // 
            calendarioAgenda.Location = new Point(18, 27);
            calendarioAgenda.Name = "calendarioAgenda";
            calendarioAgenda.TabIndex = 0;
            // 
            // comboHorario
            // 
            comboHorario.Font = new Font("Segoe UI", 10F);
            comboHorario.FormattingEnabled = true;
            comboHorario.Location = new Point(312, 58);
            comboHorario.Name = "comboHorario";
            comboHorario.Size = new Size(148, 25);
            comboHorario.TabIndex = 1;
            comboHorario.SelectedIndexChanged += comboHorario_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(257, 18);
            label1.Name = "label1";
            label1.Size = new Size(274, 37);
            label1.TabIndex = 2;
            label1.Text = "Selecione um horário:";
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(312, 199);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(148, 31);
            btnAgendar.TabIndex = 3;
            btnAgendar.Text = "AGENDAR";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(269, 101);
            label2.Name = "label2";
            label2.Size = new Size(251, 37);
            label2.TabIndex = 4;
            label2.Text = "Selecione o Serviço:";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(312, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 25);
            comboBox1.TabIndex = 5;
            // 
            // FormAgendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(560, 242);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(btnAgendar);
            Controls.Add(label1);
            Controls.Add(comboHorario);
            Controls.Add(calendarioAgenda);
            Name = "FormAgendamento";
            Text = "FormAgendamento";
            Load += FormAgendamento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar calendarioAgenda;
        private ComboBox comboHorario;
        private Label label1;
        private Button btnAgendar;
        private Label label2;
        private ComboBox comboBox1;
    }
}