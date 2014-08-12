namespace Forca
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxErro = new System.Windows.Forms.TextBox();
            this.textBoxPalpite = new System.Windows.Forms.TextBox();
            this.tentativas = new System.Windows.Forms.Label();
            this.ntentativas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Dica = new System.Windows.Forms.Label();
            this.NovoJogo = new System.Windows.Forms.Button();
            this.Tentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palpite:";
            // 
            // textBoxErro
            // 
            this.textBoxErro.Location = new System.Drawing.Point(32, 208);
            this.textBoxErro.Name = "textBoxErro";
            this.textBoxErro.Size = new System.Drawing.Size(232, 20);
            this.textBoxErro.TabIndex = 1;
            // 
            // textBoxPalpite
            // 
            this.textBoxPalpite.Location = new System.Drawing.Point(64, 48);
            this.textBoxPalpite.Name = "textBoxPalpite";
            this.textBoxPalpite.Size = new System.Drawing.Size(100, 20);
            this.textBoxPalpite.TabIndex = 2;
            // 
            // tentativas
            // 
            this.tentativas.AutoSize = true;
            this.tentativas.Location = new System.Drawing.Point(184, 56);
            this.tentativas.Name = "tentativas";
            this.tentativas.Size = new System.Drawing.Size(60, 13);
            this.tentativas.TabIndex = 3;
            this.tentativas.Text = "Tentativas:";
            // 
            // ntentativas
            // 
            this.ntentativas.AutoSize = true;
            this.ntentativas.Location = new System.Drawing.Point(256, 56);
            this.ntentativas.Name = "ntentativas";
            this.ntentativas.Size = new System.Drawing.Size(13, 13);
            this.ntentativas.TabIndex = 4;
            this.ntentativas.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Letras Erradas";
            // 
            // Dica
            // 
            this.Dica.AutoSize = true;
            this.Dica.Location = new System.Drawing.Point(120, 136);
            this.Dica.Name = "Dica";
            this.Dica.Size = new System.Drawing.Size(35, 13);
            this.Dica.TabIndex = 6;
            this.Dica.Text = "label5";
            // 
            // NovoJogo
            // 
            this.NovoJogo.Location = new System.Drawing.Point(8, 8);
            this.NovoJogo.Name = "NovoJogo";
            this.NovoJogo.Size = new System.Drawing.Size(75, 23);
            this.NovoJogo.TabIndex = 7;
            this.NovoJogo.Text = "Novo Jogo";
            this.NovoJogo.UseVisualStyleBackColor = true;
            this.NovoJogo.Click += new System.EventHandler(this.NovoJogo_Click);
            // 
            // Tentar
            // 
            this.Tentar.Location = new System.Drawing.Point(8, 88);
            this.Tentar.Name = "Tentar";
            this.Tentar.Size = new System.Drawing.Size(75, 23);
            this.Tentar.TabIndex = 8;
            this.Tentar.Text = "Tentar";
            this.Tentar.UseVisualStyleBackColor = true;
            this.Tentar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 262);
            this.Controls.Add(this.Tentar);
            this.Controls.Add(this.NovoJogo);
            this.Controls.Add(this.Dica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ntentativas);
            this.Controls.Add(this.tentativas);
            this.Controls.Add(this.textBoxPalpite);
            this.Controls.Add(this.textBoxErro);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Forca 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxErro;
        private System.Windows.Forms.TextBox textBoxPalpite;
        private System.Windows.Forms.Label tentativas;
        private System.Windows.Forms.Label ntentativas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Dica;
        private System.Windows.Forms.Button NovoJogo;
        private System.Windows.Forms.Button Tentar;
    }
}

