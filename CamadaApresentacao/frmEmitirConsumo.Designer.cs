namespace CamadaApresentacao
{
    partial class frmEmitirConsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmitirConsumo));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridEmitir = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBConta = new System.Windows.Forms.Button();
            this.btnEmitirConta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmitir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF Morador: ";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(104, 24);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(113, 20);
            this.txtCPF.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contas: ";
            // 
            // dataGridEmitir
            // 
            this.dataGridEmitir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmitir.Location = new System.Drawing.Point(36, 124);
            this.dataGridEmitir.Name = "dataGridEmitir";
            this.dataGridEmitir.Size = new System.Drawing.Size(507, 105);
            this.dataGridEmitir.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "v1.0";
            // 
            // btnBConta
            // 
            this.btnBConta.Location = new System.Drawing.Point(246, 22);
            this.btnBConta.Name = "btnBConta";
            this.btnBConta.Size = new System.Drawing.Size(75, 23);
            this.btnBConta.TabIndex = 5;
            this.btnBConta.Text = "Buscar";
            this.btnBConta.UseVisualStyleBackColor = true;
            this.btnBConta.Click += new System.EventHandler(this.btnBConta_Click);
            // 
            // btnEmitirConta
            // 
            this.btnEmitirConta.Location = new System.Drawing.Point(468, 281);
            this.btnEmitirConta.Name = "btnEmitirConta";
            this.btnEmitirConta.Size = new System.Drawing.Size(75, 23);
            this.btnEmitirConta.TabIndex = 6;
            this.btnEmitirConta.Text = "Emitir";
            this.btnEmitirConta.UseVisualStyleBackColor = true;
            // 
            // frmEmitirConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(565, 425);
            this.Controls.Add(this.btnEmitirConta);
            this.Controls.Add(this.btnBConta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridEmitir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label1);
            this.Name = "frmEmitirConsumo";
            this.Text = "Emitir Consumo";
            this.Load += new System.EventHandler(this.frmEmitirConsumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmitir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridEmitir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBConta;
        private System.Windows.Forms.Button btnEmitirConta;
    }
}