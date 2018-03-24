namespace CamadaApresentacao
{
    partial class frmServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServico));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrdemS = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtDetalhes = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.dtExecucao = new System.Windows.Forms.DateTimePicker();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "v1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ordem de serviço Nº:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(164, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Empresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(29, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome do Solicitante:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(379, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Serviço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(379, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data de execução:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(29, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "Detalhes:";
            // 
            // txtOrdemS
            // 
            this.txtOrdemS.Location = new System.Drawing.Point(32, 41);
            this.txtOrdemS.Name = "txtOrdemS";
            this.txtOrdemS.Size = new System.Drawing.Size(116, 20);
            this.txtOrdemS.TabIndex = 7;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(167, 41);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(196, 20);
            this.txtEmpresa.TabIndex = 8;
            // 
            // txtDetalhes
            // 
            this.txtDetalhes.Location = new System.Drawing.Point(32, 149);
            this.txtDetalhes.Name = "txtDetalhes";
            this.txtDetalhes.Size = new System.Drawing.Size(331, 20);
            this.txtDetalhes.TabIndex = 11;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(32, 95);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(331, 20);
            this.txtNome.TabIndex = 12;
            // 
            // txtServico
            // 
            this.txtServico.Location = new System.Drawing.Point(382, 41);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(233, 20);
            this.txtServico.TabIndex = 13;
            // 
            // dtExecucao
            // 
            this.dtExecucao.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtExecucao.Location = new System.Drawing.Point(382, 95);
            this.dtExecucao.Name = "dtExecucao";
            this.dtExecucao.Size = new System.Drawing.Size(233, 20);
            this.dtExecucao.TabIndex = 14;
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnInserir.Location = new System.Drawing.Point(32, 187);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 15;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnConsultar.Location = new System.Drawing.Point(540, 225);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnExcluir.Location = new System.Drawing.Point(540, 274);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dataLista
            // 
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Location = new System.Drawing.Point(32, 225);
            this.dataLista.Name = "dataLista";
            this.dataLista.Size = new System.Drawing.Size(502, 159);
            this.dataLista.TabIndex = 20;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(436, 209);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(98, 13);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Todos os Registros";
            // 
            // frmServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(627, 396);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataLista);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.dtExecucao);
            this.Controls.Add(this.txtServico);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtDetalhes);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtOrdemS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmServico";
            this.Text = "Servicos";
            this.Load += new System.EventHandler(this.frmServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrdemS;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtDetalhes;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.DateTimePicker dtExecucao;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.Label lblTotal;
    }
}