namespace estadisticaApp
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.lblName = new System.Windows.Forms.Label();
            this.btnBinomial = new System.Windows.Forms.Button();
            this.btnHipergeometrica = new System.Windows.Forms.Button();
            this.btnMultinomial = new System.Windows.Forms.Button();
            this.btnPoisson = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(434, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(391, 55);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "PROBABILIDAD";
            // 
            // btnBinomial
            // 
            this.btnBinomial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBinomial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinomial.Location = new System.Drawing.Point(292, 183);
            this.btnBinomial.Name = "btnBinomial";
            this.btnBinomial.Size = new System.Drawing.Size(311, 148);
            this.btnBinomial.TabIndex = 1;
            this.btnBinomial.Text = "Probabilidad Binomial";
            this.btnBinomial.UseVisualStyleBackColor = true;
            this.btnBinomial.Click += new System.EventHandler(this.btnBinomial_Click);
            this.btnBinomial.MouseEnter += new System.EventHandler(this.btnBinomial_MouseEnter_1);
            // 
            // btnHipergeometrica
            // 
            this.btnHipergeometrica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHipergeometrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHipergeometrica.Location = new System.Drawing.Point(653, 183);
            this.btnHipergeometrica.Name = "btnHipergeometrica";
            this.btnHipergeometrica.Size = new System.Drawing.Size(311, 148);
            this.btnHipergeometrica.TabIndex = 2;
            this.btnHipergeometrica.Text = "Probabilidad Hipergeometrica";
            this.btnHipergeometrica.UseVisualStyleBackColor = true;
            this.btnHipergeometrica.Click += new System.EventHandler(this.btnHipergeometrica_Click);
            this.btnHipergeometrica.MouseEnter += new System.EventHandler(this.btnHipergeometrica_MouseEnter);
            // 
            // btnMultinomial
            // 
            this.btnMultinomial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultinomial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultinomial.Location = new System.Drawing.Point(292, 361);
            this.btnMultinomial.Name = "btnMultinomial";
            this.btnMultinomial.Size = new System.Drawing.Size(311, 148);
            this.btnMultinomial.TabIndex = 3;
            this.btnMultinomial.Text = "Distribución Multinomial";
            this.btnMultinomial.UseVisualStyleBackColor = true;
            this.btnMultinomial.Click += new System.EventHandler(this.btnMultinomial_Click);
            this.btnMultinomial.MouseEnter += new System.EventHandler(this.btnMultinomial_MouseEnter);
            // 
            // btnPoisson
            // 
            this.btnPoisson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPoisson.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoisson.Location = new System.Drawing.Point(653, 361);
            this.btnPoisson.Name = "btnPoisson";
            this.btnPoisson.Size = new System.Drawing.Size(311, 148);
            this.btnPoisson.TabIndex = 4;
            this.btnPoisson.Text = "Distribución de Poisson";
            this.btnPoisson.UseVisualStyleBackColor = true;
            this.btnPoisson.Click += new System.EventHandler(this.btnPoisson_Click);
            this.btnPoisson.MouseEnter += new System.EventHandler(this.btnPoisson_MouseEnter);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(1084, 580);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(84, 62);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1180, 654);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnPoisson);
            this.Controls.Add(this.btnMultinomial);
            this.Controls.Add(this.btnHipergeometrica);
            this.Controls.Add(this.btnBinomial);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnBinomial;
        private System.Windows.Forms.Button btnHipergeometrica;
        private System.Windows.Forms.Button btnMultinomial;
        private System.Windows.Forms.Button btnPoisson;
        private System.Windows.Forms.Button btnCerrar;
    }
}

