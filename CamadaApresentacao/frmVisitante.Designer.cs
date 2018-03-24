namespace CamadaApresentacao
{
    partial class frmVisitante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisitante));
            this.Nome = new System.Windows.Forms.Label();
            this.RG = new System.Windows.Forms.Label();
            this.dtVisita = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.btnRenomear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Nome.Location = new System.Drawing.Point(40, 27);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(42, 14);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome:";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // RG
            // 
            this.RG.AutoSize = true;
            this.RG.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.RG.Location = new System.Drawing.Point(40, 76);
            this.RG.Name = "RG";
            this.RG.Size = new System.Drawing.Size(25, 14);
            this.RG.TabIndex = 1;
            this.RG.Text = "RG:";
            // 
            // dtVisita
            // 
            this.dtVisita.Font = new System.Drawing.Font("Arial", 8.25F);
            this.dtVisita.Location = new System.Drawing.Point(43, 142);
            this.dtVisita.Name = "dtVisita";
            this.dtVisita.Size = new System.Drawing.Size(243, 20);
            this.dtVisita.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(40, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data da Visita";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(43, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(243, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(43, 92);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(117, 20);
            this.txtRG.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnAdicionar.Location = new System.Drawing.Point(43, 180);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnConsultar.Location = new System.Drawing.Point(482, 235);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(102, 23);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnExcluir.Location = new System.Drawing.Point(482, 312);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 23);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dataLista
            // 
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Location = new System.Drawing.Point(43, 235);
            this.dataLista.Name = "dataLista";
            this.dataLista.Size = new System.Drawing.Size(433, 182);
            this.dataLista.TabIndex = 9;
            // 
            // btnRenomear
            // 
            this.btnRenomear.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnRenomear.Location = new System.Drawing.Point(482, 274);
            this.btnRenomear.Name = "btnRenomear";
            this.btnRenomear.Size = new System.Drawing.Size(102, 23);
            this.btnRenomear.TabIndex = 10;
            this.btnRenomear.Text = "Renomear";
            this.btnRenomear.UseVisualStyleBackColor = true;
            this.btnRenomear.Click += new System.EventHandler(this.btnRenomear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "v1.0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(384, 219);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 13);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Lista de Visitantes";
            // 
            // frmVisitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(596, 438);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRenomear);
            this.Controls.Add(this.dataLista);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtVisita);
            this.Controls.Add(this.RG);
            this.Controls.Add(this.Nome);
            this.Name = "frmVisitante";
            this.Text = "Inserir Visitantes";
            this.Load += new System.EventHandler(this.frmVisitante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label RG;
        private System.Windows.Forms.DateTimePicker dtVisita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.Button btnRenomear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
    }
}