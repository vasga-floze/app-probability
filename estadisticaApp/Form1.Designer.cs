namespace estadisticaApp
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
            this.lblName = new System.Windows.Forms.Label();
            this.btnBinomial = new System.Windows.Forms.Button();
            this.btnHipergeometrica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(391, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(271, 38);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "PROBABILIDAD";
            // 
            // btnBinomial
            // 
            this.btnBinomial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinomial.Location = new System.Drawing.Point(328, 142);
            this.btnBinomial.Name = "btnBinomial";
            this.btnBinomial.Size = new System.Drawing.Size(225, 101);
            this.btnBinomial.TabIndex = 1;
            this.btnBinomial.Text = "Probabilidad Binomial";
            this.btnBinomial.UseVisualStyleBackColor = true;
            this.btnBinomial.Click += new System.EventHandler(this.btnBinomial_Click);
            // 
            // btnHipergeometrica
            // 
            this.btnHipergeometrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHipergeometrica.Location = new System.Drawing.Point(580, 142);
            this.btnHipergeometrica.Name = "btnHipergeometrica";
            this.btnHipergeometrica.Size = new System.Drawing.Size(229, 101);
            this.btnHipergeometrica.TabIndex = 2;
            this.btnHipergeometrica.Text = "Probabilidad Hipergeometrica";
            this.btnHipergeometrica.UseVisualStyleBackColor = true;
            this.btnHipergeometrica.Click += new System.EventHandler(this.btnHipergeometrica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 633);
            this.Controls.Add(this.btnHipergeometrica);
            this.Controls.Add(this.btnBinomial);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnBinomial;
        private System.Windows.Forms.Button btnHipergeometrica;
    }
}

