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
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 123);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Senha:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 86);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            label2.Click += label2_Click;
            // 
            // senha
            // 
            senha.Location = new Point(199, 119);
            senha.Margin = new Padding(2, 2, 2, 2);
            senha.Name = "senha";
            senha.Size = new Size(142, 23);
            senha.TabIndex = 2;
            senha.Text = "Digite sua senha aqui";
            senha.TextChanged += textBox1_TextChanged;
            // 
            // email
            // 
            email.Location = new Point(199, 83);
            email.Margin = new Padding(2, 2, 2, 2);
            email.Name = "email";
            email.Size = new Size(142, 23);
            email.TabIndex = 3;
            email.Text = "Digite seu email aqui";
            email.TextChanged += textBox2_TextChanged;
            // 
            // botaoEntrada
            // 
            botaoEntrada.Location = new Point(225, 155);
            botaoEntrada.Margin = new Padding(2, 2, 2, 2);
            botaoEntrada.Name = "botaoEntrada";
            botaoEntrada.Size = new Size(78, 20);
            botaoEntrada.TabIndex = 4;
            botaoEntrada.Text = "Entrar";
            botaoEntrada.UseVisualStyleBackColor = true;
            botaoEntrada.Click += botaoEntrada_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(140, 31);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(248, 28);
            label3.TabIndex = 5;
            label3.Text = "AGENDA DA BARBEARIA";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(454, 7);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(98, 20);
            button1.TabIndex = 6;
            button1.Text = "Administrador";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(140, 186);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(243, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Caso você não possua cadastro. Clique Aqui.";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(560, 242);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(botaoEntrada);
            Controls.Add(email);
            Controls.Add(senha);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
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
        private Button button1;
        private LinkLabel linkLabel1;
        private System.Windows.Forms.Label Cadastro;
        this.button1.Click += new System.EventHandler(this.button1_Click);



        }
    }
}