namespace AgendaBarbearia
{
    partial class Relatorio
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
            dataGridView1 = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            label1 = new Label();
            botaoEntrada = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PowderBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, Data, Hora });
            dataGridView1.Location = new Point(25, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(516, 225);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nome
            // 
            Nome.HeaderText = "Cliente";
            Nome.MinimumWidth = 8;
            Nome.Name = "Nome";
            Nome.Width = 150;
            // 
            // Data
            // 
            Data.HeaderText = "Data";
            Data.MinimumWidth = 8;
            Data.Name = "Data";
            Data.Width = 150;
            // 
            // Hora
            // 
            Hora.HeaderText = "Hora";
            Hora.MinimumWidth = 8;
            Hora.Name = "Hora";
            Hora.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(599, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 41);
            label1.TabIndex = 1;
            label1.Text = "AGENDA";
            label1.Click += label1_Click;
            // 
            // botaoEntrada
            // 
            botaoEntrada.Location = new Point(599, 212);
            botaoEntrada.Margin = new Padding(4, 5, 4, 5);
            botaoEntrada.Name = "botaoEntrada";
            botaoEntrada.Size = new Size(145, 39);
            botaoEntrada.TabIndex = 7;
            botaoEntrada.Text = "SAIR";
            botaoEntrada.UseVisualStyleBackColor = true;
            botaoEntrada.Click += botaoEntrada_Click;
            // 
            // Relatorio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 403);
            Controls.Add(botaoEntrada);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Relatorio";
            Text = "Relatorio";
            Load += Relatorio_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Hora;
        private Label label1;
        private Button botaoEntrada;
    }
}