namespace AgendaBarbearia
{
    partial class AreadoADM
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
            label1 = new Label();
            label2 = new Label();
            FotoBarbearia = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)FotoBarbearia).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 49);
            label1.Name = "label1";
            label1.Size = new Size(242, 25);
            label1.TabIndex = 0;
            label1.Text = "ÁREA DO ADMINISTRADOR ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 92);
            label2.Name = "label2";
            label2.Size = new Size(614, 25);
            label2.TabIndex = 1;
            label2.Text = "Clique abaixo para visualizar os dias que você tem serviços na sua Barbearia.";
            label2.Click += label2_Click;
            // 
            // FotoBarbearia
            // 
            FotoBarbearia.Image = Properties.Resources.BARBEARIA;
            FotoBarbearia.Location = new Point(0, 0);
            FotoBarbearia.Name = "FotoBarbearia";
            FotoBarbearia.Size = new Size(0, 0);
            FotoBarbearia.SizeMode = PictureBoxSizeMode.StretchImage;
            FotoBarbearia.TabIndex = 2;
            FotoBarbearia.TabStop = false;
            FotoBarbearia.Click += pictureBox1_Click;
            // 
            // AreadoADM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FotoBarbearia);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AreadoADM";
            Text = "AreadoADM";
            Load += AreadoADM_Load;
            ((System.ComponentModel.ISupportInitialize)FotoBarbearia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox FotoBarbearia;
    }
}