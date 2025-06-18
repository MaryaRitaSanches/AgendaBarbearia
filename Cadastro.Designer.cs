namespace AgendaBarbearia
{
    partial class Cadastro
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
            label3 = new Label();
            botaoEntrada = new Button();
            email = new TextBox();
            senha = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(326, 15);
            label3.Name = "label3";
            label3.Size = new Size(217, 41);
            label3.TabIndex = 6;
            label3.Text = "CADASTRE-SE";
            label3.Click += label3_Click;
            // 
            // botaoEntrada
            // 
            botaoEntrada.Location = new Point(359, 343);
            botaoEntrada.Name = "botaoEntrada";
            botaoEntrada.Size = new Size(111, 33);
            botaoEntrada.TabIndex = 11;
            botaoEntrada.Text = "Cadastrar";
            botaoEntrada.UseVisualStyleBackColor = true;
            // 
            // email
            // 
            email.Location = new Point(329, 152);
            email.Name = "email";
            email.Size = new Size(201, 31);
            email.TabIndex = 10;
            email.Text = "Digite seu email aqui";
            // 
            // senha
            // 
            senha.Location = new Point(329, 212);
            senha.Name = "senha";
            senha.Size = new Size(201, 31);
            senha.TabIndex = 9;
            senha.Text = "Digite sua senha aqui";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 157);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 8;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 218);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 7;
            label1.Text = "Senha:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(329, 278);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 31);
            textBox1.TabIndex = 12;
            textBox1.Text = "Digite sua senha aqui";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(181, 283);
            label4.Name = "label4";
            label4.Size = new Size(148, 25);
            label4.TabIndex = 13;
            label4.Text = "Confime a senha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(267, 93);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 14;
            label5.Text = "Nome:";
            label5.Click += label5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(329, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 31);
            textBox2.TabIndex = 15;
            textBox2.Text = "Digite seu nome aqui";
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(800, 403);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(botaoEntrada);
            Controls.Add(email);
            Controls.Add(senha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Cadastro";
            Text = "Cadastro";
            Load += Cadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button botaoEntrada;
        private TextBox email;
        private TextBox senha;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
    }
}