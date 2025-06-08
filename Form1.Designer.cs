namespace AgendaBarbearia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            senha = new TextBox();
            email = new TextBox();
            botaoEntrada = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 180);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 0;
            label1.Text = "Senha:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 119);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            label2.Click += label2_Click;
            // 
            // senha
            // 
            senha.Location = new Point(299, 174);
            senha.Name = "senha";
            senha.Size = new Size(201, 31);
            senha.TabIndex = 2;
            senha.Text = "Digite sua senha aqui";
            senha.TextAlign = HorizontalAlignment.Center;
            senha.TextChanged += textBox1_TextChanged;
            // 
            // email
            // 
            email.Location = new Point(299, 113);
            email.Name = "email";
            email.Size = new Size(201, 31);
            email.TabIndex = 3;
            email.Text = "Digite seu email aqui";
            email.TextChanged += textBox2_TextChanged;
            // 
            // botaoEntrada
            // 
            botaoEntrada.Location = new Point(331, 242);
            botaoEntrada.Name = "botaoEntrada";
            botaoEntrada.Size = new Size(112, 34);
            botaoEntrada.TabIndex = 4;
            botaoEntrada.Text = "Entrar";
            botaoEntrada.UseVisualStyleBackColor = true;
            botaoEntrada.Click += botaoEntrada_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(277, 41);
            label3.Name = "label3";
            label3.Size = new Size(267, 30);
            label3.TabIndex = 5;
            label3.Text = "AGENDA DA BARBEARIA";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(800, 403);
            Controls.Add(label3);
            Controls.Add(botaoEntrada);
            Controls.Add(email);
            Controls.Add(senha);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox senha;
        private TextBox email;
        private Button botaoEntrada;
        private Label label3;
    }
}
