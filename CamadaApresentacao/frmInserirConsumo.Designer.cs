namespace CamadaApresentacao
{
    partial class frmInserirConsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserirConsumo));
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.txtQntA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQntL = new System.Windows.Forms.TextBox();
            this.txtValorL = new System.Windows.Forms.TextBox();
            this.dtVencimento = new System.Windows.Forms.DateTimePicker();
            this.txtQntG = new System.Windows.Forms.TextBox();
            this.txtValorG = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(237, 365);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(101, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(39, 20);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gás";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Água";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade(m³):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Luz";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "ID Morador";
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(38, 121);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(94, 20);
            this.txtValorA.TabIndex = 21;
            // 
            // txtQntA
            // 
            this.txtQntA.Location = new System.Drawing.Point(160, 121);
            this.txtQntA.Name = "txtQntA";
            this.txtQntA.Size = new System.Drawing.Size(94, 20);
            this.txtQntA.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Valor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Valor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Quantidade(kMh)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(155, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Quantidade(Kg):";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtQntL
            // 
            this.txtQntL.Location = new System.Drawing.Point(160, 212);
            this.txtQntL.Name = "txtQntL";
            this.txtQntL.Size = new System.Drawing.Size(94, 20);
            this.txtQntL.TabIndex = 35;
            // 
            // txtValorL
            // 
            this.txtValorL.Location = new System.Drawing.Point(38, 212);
            this.txtValorL.Name = "txtValorL";
            this.txtValorL.Size = new System.Drawing.Size(94, 20);
            this.txtValorL.TabIndex = 34;
            // 
            // dtVencimento
            // 
            this.dtVencimento.Location = new System.Drawing.Point(321, 297);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.Size = new System.Drawing.Size(232, 20);
            this.dtVencimento.TabIndex = 39;
            // 
            // txtQntG
            // 
            this.txtQntG.Location = new System.Drawing.Point(160, 297);
            this.txtQntG.Name = "txtQntG";
            this.txtQntG.Size = new System.Drawing.Size(94, 20);
            this.txtQntG.TabIndex = 38;
            // 
            // txtValorG
            // 
            this.txtValorG.Location = new System.Drawing.Point(38, 297);
            this.txtValorG.Name = "txtValorG";
            this.txtValorG.Size = new System.Drawing.Size(94, 20);
            this.txtValorG.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(318, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Data vencimento:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(525, 403);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "v1.0";
            // 
            // frmInserirConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(565, 425);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtVencimento);
            this.Controls.Add(this.txtQntG);
            this.Controls.Add(this.txtValorG);
            this.Controls.Add(this.txtQntL);
            this.Controls.Add(this.txtValorL);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQntA);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnInserir);
            this.Name = "frmInserirConsumo";
            this.Text = "Inserir Consumo";
            this.Load += new System.EventHandler(this.frmInserirConsumo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.TextBox txtQntA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtQntL;
        private System.Windows.Forms.TextBox txtValorL;
        private System.Windows.Forms.DateTimePicker dtVencimento;
        private System.Windows.Forms.TextBox txtQntG;
        private System.Windows.Forms.TextBox txtValorG;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}