namespace estadisticaApp
{
    partial class frmProbHipergeometrica
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
            this.btnBack = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txt_xCantExitos = new System.Windows.Forms.TextBox();
            this.txt_aCaracteristica = new System.Windows.Forms.TextBox();
            this.txt_nMuestraPobl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nPoblacion = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(10, 565);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 59);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Atras";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.Transparent;
            this.txtResultado.Location = new System.Drawing.Point(159, 490);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(194, 34);
            this.txtResultado.TabIndex = 33;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(189, 414);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(131, 59);
            this.btnCalcular.TabIndex = 32;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(991, 574);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(131, 59);
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // txt_xCantExitos
            // 
            this.txt_xCantExitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_xCantExitos.Location = new System.Drawing.Point(238, 342);
            this.txt_xCantExitos.Name = "txt_xCantExitos";
            this.txt_xCantExitos.Size = new System.Drawing.Size(100, 34);
            this.txt_xCantExitos.TabIndex = 30;
            // 
            // txt_aCaracteristica
            // 
            this.txt_aCaracteristica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_aCaracteristica.Location = new System.Drawing.Point(238, 285);
            this.txt_aCaracteristica.Name = "txt_aCaracteristica";
            this.txt_aCaracteristica.Size = new System.Drawing.Size(100, 34);
            this.txt_aCaracteristica.TabIndex = 29;
            // 
            // txt_nMuestraPobl
            // 
            this.txt_nMuestraPobl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nMuestraPobl.Location = new System.Drawing.Point(238, 223);
            this.txt_nMuestraPobl.Name = "txt_nMuestraPobl";
            this.txt_nMuestraPobl.Size = new System.Drawing.Size(100, 34);
            this.txt_nMuestraPobl.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "x:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "n:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "N:";
            // 
            // txt_nPoblacion
            // 
            this.txt_nPoblacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nPoblacion.Location = new System.Drawing.Point(238, 166);
            this.txt_nPoblacion.Name = "txt_nPoblacion";
            this.txt_nPoblacion.Size = new System.Drawing.Size(100, 34);
            this.txt_nPoblacion.TabIndex = 23;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(297, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(617, 38);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "PROBABILIDAD HIPERGEOMETRICA";
            // 
            // frmProbHipergeometrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 697);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txt_xCantExitos);
            this.Controls.Add(this.txt_aCaracteristica);
            this.Controls.Add(this.txt_nMuestraPobl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nPoblacion);
            this.Controls.Add(this.lblName);
            this.Name = "frmProbHipergeometrica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProbHipergeometrica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txt_xCantExitos;
        private System.Windows.Forms.TextBox txt_aCaracteristica;
        private System.Windows.Forms.TextBox txt_nMuestraPobl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nPoblacion;
        private System.Windows.Forms.Label lblName;
    }
}