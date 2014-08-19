namespace Forca
{
    partial class Form2
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
            this.Palavra = new System.Windows.Forms.TextBox();
            this.Vamos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a palavra:";
            // 
            // Palavra
            // 
            this.Palavra.Location = new System.Drawing.Point(48, 88);
            this.Palavra.Name = "Palavra";
            this.Palavra.Size = new System.Drawing.Size(184, 20);
            this.Palavra.TabIndex = 1;
            // 
            // Vamos
            // 
            this.Vamos.Location = new System.Drawing.Point(96, 153);
            this.Vamos.Name = "Vamos";
            this.Vamos.Size = new System.Drawing.Size(75, 23);
            this.Vamos.TabIndex = 2;
            this.Vamos.Text = "Vamos Lá!";
            this.Vamos.UseVisualStyleBackColor = true;
            this.Vamos.Click += new System.EventHandler(this.Vamos_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 204);
            this.Controls.Add(this.Vamos);
            this.Controls.Add(this.Palavra);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Vamos;
        public System.Windows.Forms.TextBox Palavra;
    }
}