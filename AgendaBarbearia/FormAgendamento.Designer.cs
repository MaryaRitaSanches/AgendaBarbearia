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
            SuspendLayout();
            // 
            // calendarioAgenda
            // 
            calendarioAgenda.Location = new Point(31, 30);
            calendarioAgenda.Name = "calendarioAgenda";
            calendarioAgenda.TabIndex = 0;
            // 
            // comboHorario
            // 
            comboHorario.Font = new Font("Segoe UI", 10F);
            comboHorario.FormattingEnabled = true;
            comboHorario.Location = new Point(345, 84);
            comboHorario.Name = "comboHorario";
            comboHorario.Size = new Size(274, 25);
            comboHorario.TabIndex = 1;
            comboHorario.SelectedIndexChanged += comboHorario_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(345, 30);
            label1.Name = "label1";
            label1.Size = new Size(274, 37);
            label1.TabIndex = 2;
            label1.Text = "Selecione um horário:";
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(399, 130);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(161, 31);
            btnAgendar.TabIndex = 3;
            btnAgendar.Text = "Agendar Corte";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // FormAgendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}