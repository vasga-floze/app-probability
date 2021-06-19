namespace estadisticaApp
{
    partial class frmProbBinomial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProbBinomial));
            this.lblName = new System.Windows.Forms.Label();
            this.txt_pExito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_qFracaso = new System.Windows.Forms.TextBox();
            this.txt_nMuestra = new System.Windows.Forms.TextBox();
            this.txt_xVariable = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblX_ = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblN_X = new System.Windows.Forms.Label();
            this.lblParentesis3 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblParentesis2 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblParentesis1 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(357, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(536, 46);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "PROBABILIDAD BINOMIAL";
            // 
            // txt_pExito
            // 
            this.txt_pExito.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pExito.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_pExito.Location = new System.Drawing.Point(233, 187);
            this.txt_pExito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_pExito.Name = "txt_pExito";
            this.txt_pExito.Size = new System.Drawing.Size(100, 34);
            this.txt_pExito.TabIndex = 2;
            this.txt_pExito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_pExito.Validating += new System.ComponentModel.CancelEventHandler(this.txt_pExito_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(177, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "p:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(177, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "q:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(177, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "n:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(177, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "x:";
            // 
            // txt_qFracaso
            // 
            this.txt_qFracaso.Enabled = false;
            this.txt_qFracaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qFracaso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_qFracaso.Location = new System.Drawing.Point(233, 244);
            this.txt_qFracaso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_qFracaso.Name = "txt_qFracaso";
            this.txt_qFracaso.Size = new System.Drawing.Size(100, 34);
            this.txt_qFracaso.TabIndex = 7;
            this.txt_qFracaso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_nMuestra
            // 
            this.txt_nMuestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nMuestra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_nMuestra.Location = new System.Drawing.Point(233, 306);
            this.txt_nMuestra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nMuestra.Name = "txt_nMuestra";
            this.txt_nMuestra.Size = new System.Drawing.Size(100, 34);
            this.txt_nMuestra.TabIndex = 8;
            this.txt_nMuestra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_nMuestra.Validating += new System.ComponentModel.CancelEventHandler(this.txt_nMuestra_Validating);
            // 
            // txt_xVariable
            // 
            this.txt_xVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_xVariable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_xVariable.Location = new System.Drawing.Point(233, 363);
            this.txt_xVariable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_xVariable.Name = "txt_xVariable";
            this.txt_xVariable.Size = new System.Drawing.Size(100, 34);
            this.txt_xVariable.TabIndex = 9;
            this.txt_xVariable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_xVariable.Validating += new System.ComponentModel.CancelEventHandler(this.txt_xVariable_Validating);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(1062, 582);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 75);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalcular.Location = new System.Drawing.Point(193, 430);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(131, 44);
            this.btnCalcular.TabIndex = 19;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.Transparent;
            this.txtResultado.Location = new System.Drawing.Point(584, 550);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(115, 27);
            this.txtResultado.TabIndex = 20;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(28, 582);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 75);
            this.btnBack.TabIndex = 21;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(492, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "P(x) =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(580, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 69);
            this.label6.TabIndex = 23;
            this.label6.Text = "(  )";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(615, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 29);
            this.label9.TabIndex = 26;
            this.label9.Text = "n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(616, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 29);
            this.label10.TabIndex = 27;
            this.label10.Text = "x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(707, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "p";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(672, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 69);
            this.label11.TabIndex = 28;
            this.label11.Text = "(  )";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(819, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 29);
            this.label13.TabIndex = 32;
            this.label13.Text = "q";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(783, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 69);
            this.label14.TabIndex = 31;
            this.label14.Text = "(  )";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(760, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 29);
            this.label7.TabIndex = 33;
            this.label7.Text = "x";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(869, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 29);
            this.label15.TabIndex = 35;
            this.label15.Text = "n   -    x";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(492, 548);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 29);
            this.label12.TabIndex = 36;
            this.label12.Text = "P(x) =";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(707, 550);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 29);
            this.label16.TabIndex = 37;
            this.label16.Text = "%";
            // 
            // lblX_
            // 
            this.lblX_.AutoSize = true;
            this.lblX_.BackColor = System.Drawing.Color.Transparent;
            this.lblX_.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX_.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblX_.Location = new System.Drawing.Point(775, 322);
            this.lblX_.Name = "lblX_";
            this.lblX_.Size = new System.Drawing.Size(25, 29);
            this.lblX_.TabIndex = 46;
            this.lblX_.Text = "x";
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.BackColor = System.Drawing.Color.Transparent;
            this.lblQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQ.Location = new System.Drawing.Point(835, 351);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(28, 29);
            this.lblQ.TabIndex = 45;
            this.lblQ.Text = "q";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.BackColor = System.Drawing.Color.Transparent;
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblP.Location = new System.Drawing.Point(701, 351);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(28, 29);
            this.lblP.TabIndex = 43;
            this.lblP.Text = "p";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label22.Location = new System.Drawing.Point(675, 326);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(118, 69);
            this.label22.TabIndex = 42;
            this.label22.Text = "(   )";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.Color.Transparent;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblX.Location = new System.Drawing.Point(605, 366);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(25, 29);
            this.lblX.TabIndex = 41;
            this.lblX.Text = "x";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.BackColor = System.Drawing.Color.Transparent;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblN.Location = new System.Drawing.Point(605, 334);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(27, 29);
            this.lblN.TabIndex = 40;
            this.lblN.Text = "n";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label25.Location = new System.Drawing.Point(571, 327);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(118, 69);
            this.label25.TabIndex = 39;
            this.label25.Text = "(   )";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label26.Location = new System.Drawing.Point(492, 354);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(82, 29);
            this.label26.TabIndex = 38;
            this.label26.Text = "P(x) =";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(799, 327);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(134, 69);
            this.label20.TabIndex = 44;
            this.label20.Text = "(    )";
            // 
            // lblN_X
            // 
            this.lblN_X.AutoSize = true;
            this.lblN_X.BackColor = System.Drawing.Color.Transparent;
            this.lblN_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN_X.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblN_X.Location = new System.Drawing.Point(929, 322);
            this.lblN_X.Name = "lblN_X";
            this.lblN_X.Size = new System.Drawing.Size(97, 29);
            this.lblN_X.TabIndex = 47;
            this.lblN_X.Text = "n   -    x";
            // 
            // lblParentesis3
            // 
            this.lblParentesis3.AutoSize = true;
            this.lblParentesis3.BackColor = System.Drawing.Color.Transparent;
            this.lblParentesis3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentesis3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblParentesis3.Location = new System.Drawing.Point(928, 454);
            this.lblParentesis3.Name = "lblParentesis3";
            this.lblParentesis3.Size = new System.Drawing.Size(0, 29);
            this.lblParentesis3.TabIndex = 55;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(884, 430);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(182, 69);
            this.label21.TabIndex = 54;
            this.label21.Text = "(       )";
            // 
            // lblParentesis2
            // 
            this.lblParentesis2.AutoSize = true;
            this.lblParentesis2.BackColor = System.Drawing.Color.Transparent;
            this.lblParentesis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentesis2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblParentesis2.Location = new System.Drawing.Point(761, 454);
            this.lblParentesis2.Name = "lblParentesis2";
            this.lblParentesis2.Size = new System.Drawing.Size(0, 29);
            this.lblParentesis2.TabIndex = 53;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label24.Location = new System.Drawing.Point(723, 430);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(166, 69);
            this.label24.TabIndex = 52;
            this.label24.Text = "(      )";
            // 
            // lblParentesis1
            // 
            this.lblParentesis1.AutoSize = true;
            this.lblParentesis1.BackColor = System.Drawing.Color.Transparent;
            this.lblParentesis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentesis1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblParentesis1.Location = new System.Drawing.Point(607, 454);
            this.lblParentesis1.Name = "lblParentesis1";
            this.lblParentesis1.Size = new System.Drawing.Size(0, 29);
            this.lblParentesis1.TabIndex = 50;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label29.Location = new System.Drawing.Point(565, 430);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(166, 69);
            this.label29.TabIndex = 49;
            this.label29.Text = "(      )";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label30.Location = new System.Drawing.Point(492, 458);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(82, 29);
            this.label30.TabIndex = 48;
            this.label30.Text = "P(x) =";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(579, 133);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmProbBinomial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1187, 679);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblParentesis3);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblParentesis2);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.lblParentesis1);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.lblN_X);
            this.Controls.Add(this.lblX_);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txt_xVariable);
            this.Controls.Add(this.txt_nMuestra);
            this.Controls.Add(this.txt_qFracaso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pExito);
            this.Controls.Add(this.lblName);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProbBinomial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProbBinomial";
            this.Load += new System.EventHandler(this.frmProbBinomial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txt_pExito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_qFracaso;
        private System.Windows.Forms.TextBox txt_nMuestra;
        private System.Windows.Forms.TextBox txt_xVariable;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblX_;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblN_X;
        private System.Windows.Forms.Label lblParentesis3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblParentesis2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblParentesis1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}