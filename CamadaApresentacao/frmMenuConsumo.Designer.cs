namespace CamadaApresentacao
{
    partial class frmMenuConsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuConsumo));
            this.btnInserirConsumo = new System.Windows.Forms.Button();
            this.btnEmitirConsumo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInserirConsumo
            // 
            this.btnInserirConsumo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInserirConsumo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInserirConsumo.ForeColor = System.Drawing.Color.SeaShell;
            this.btnInserirConsumo.Location = new System.Drawing.Point(22, 105);
            this.btnInserirConsumo.Name = "btnInserirConsumo";
            this.btnInserirConsumo.Size = new System.Drawing.Size(325, 86);
            this.btnInserirConsumo.TabIndex = 0;
            this.btnInserirConsumo.Text = "INSERIR CONSUMO";
            this.btnInserirConsumo.UseVisualStyleBackColor = false;
            this.btnInserirConsumo.Click += new System.EventHandler(this.btnInserirConsumo_Click);
            // 
            // btnEmitirConsumo
            // 
            this.btnEmitirConsumo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEmitirConsumo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEmitirConsumo.ForeColor = System.Drawing.Color.SeaShell;
            this.btnEmitirConsumo.Location = new System.Drawing.Point(367, 105);
            this.btnEmitirConsumo.Name = "btnEmitirConsumo";
            this.btnEmitirConsumo.Size = new System.Drawing.Size(325, 86);
            this.btnEmitirConsumo.TabIndex = 2;
            this.btnEmitirConsumo.Text = "EMITIR CONSUMO";
            this.btnEmitirConsumo.UseVisualStyleBackColor = false;
            this.btnEmitirConsumo.Click += new System.EventHandler(this.btnEmitirConsumo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "v1.0";
            // 
            // frmMenuConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(713, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEmitirConsumo);
            this.Controls.Add(this.btnInserirConsumo);
            this.Name = "frmMenuConsumo";
            this.Text = "Menu Consumo";
            this.Load += new System.EventHandler(this.frmMenuConsumo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserirConsumo;
        private System.Windows.Forms.Button btnEmitirConsumo;
        private System.Windows.Forms.Label label1;
    }
}