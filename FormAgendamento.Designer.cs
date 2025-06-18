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
            calendarioAgenda.Location = new Point(26, 45);
            calendarioAgenda.Margin = new Padding(13, 15, 13, 15);
            calendarioAgenda.Name = "calendarioAgenda";
            calendarioAgenda.TabIndex = 0;
            // 
            // comboHorario
            // 
            comboHorario.Font = new Font("Segoe UI", 10F);
            comboHorario.FormattingEnabled = true;
            comboHorario.Location = new Point(446, 97);
            comboHorario.Margin = new Padding(4, 5, 4, 5);
            comboHorario.Name = "comboHorario";
            comboHorario.Size = new Size(210, 36);
            comboHorario.TabIndex = 1;
            comboHorario.SelectedIndexChanged += comboHorario_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(367, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(406, 54);
            label1.TabIndex = 2;
            label1.Text = "Selecione um horário:";
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(446, 332);
            btnAgendar.Margin = new Padding(4, 5, 4, 5);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(211, 52);
            btnAgendar.TabIndex = 3;
            btnAgendar.Text = "AGENDAR";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(384, 168);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(371, 54);
            label2.TabIndex = 4;
            label2.Text = "Selecione o Serviço:";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(446, 235);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 36);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // FormAgendamento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(800, 403);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(btnAgendar);
            Controls.Add(label1);
            Controls.Add(comboHorario);
            Controls.Add(calendarioAgenda);
            Margin = new Padding(4, 5, 4, 5);
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