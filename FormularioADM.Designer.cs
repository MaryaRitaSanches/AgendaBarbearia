namespace AgendaBarbearia
{
    partial class FormularioADM
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

        private void InitializeComponent()
        {
            label1 = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            botaoEntrada = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(178, 24);
            label1.Name = "label1";
            label1.Size = new Size(181, 28);
            label1.TabIndex = 0;
            label1.Text = "ADMINISTRADOR";
            label1.Click += label1_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(194, 81);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(151, 23);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "Digite seu email aqui";
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(194, 122);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(151, 23);
            txtSenha.TabIndex = 2;
            txtSenha.Text = "Digite sua senha aqui";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 81);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 124);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Senha";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(148, 190);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(241, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Caso você não possua cadastro. Clique aqui.";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // botaoEntrada
            // 
            botaoEntrada.Location = new Point(225, 159);
            botaoEntrada.Name = "botaoEntrada";
            botaoEntrada.Size = new Size(78, 20);
            botaoEntrada.TabIndex = 6;
            botaoEntrada.Text = "Entrar";
            botaoEntrada.UseVisualStyleBackColor = true;
            botaoEntrada.Click += botaoEntrada_Click;
            // 
            // FormularioADM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(560, 242);
            Controls.Add(botaoEntrada);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Name = "FormularioADM";
            Text = "FormularioADM";
            Load += FormularioADM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private Button botaoEntrada;
    }
}