namespace CamadaApresentacao
{
    partial class frmReuniao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReuniao));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtReuniao = new System.Windows.Forms.DateTimePicker();
            this.txtInformacoes = new System.Windows.Forms.TextBox();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.class1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.class1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbAssunto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "v1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data da reunião:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Assunto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Responsável";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Informações Adicionais:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtReuniao
            // 
            this.dtReuniao.Location = new System.Drawing.Point(157, 92);
            this.dtReuniao.Name = "dtReuniao";
            this.dtReuniao.Size = new System.Drawing.Size(247, 20);
            this.dtReuniao.TabIndex = 5;
            this.dtReuniao.ValueChanged += new System.EventHandler(this.dtReuniao_ValueChanged);
            // 
            // txtInformacoes
            // 
            this.txtInformacoes.Location = new System.Drawing.Point(30, 144);
            this.txtInformacoes.Multiline = true;
            this.txtInformacoes.Name = "txtInformacoes";
            this.txtInformacoes.Size = new System.Drawing.Size(374, 39);
            this.txtInformacoes.TabIndex = 8;
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(30, 92);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(100, 20);
            this.txtResponsavel.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // class1BindingSource
            // 
            this.class1BindingSource.DataSource = typeof(CamadaNegocio.Class1);
            // 
            // class1BindingSource1
            // 
            this.class1BindingSource1.DataSource = typeof(CamadaNegocio.Class1);
            // 
            // cbAssunto
            // 
            this.cbAssunto.AutoCompleteCustomSource.AddRange(new string[] {
            "Melhoria na infraestrutura",
            "Contratação de serviços",
            "Eleição de diretoria",
            "Definição, modificação e ponderação sobre regras",
            "Outras"});
            this.cbAssunto.FormattingEnabled = true;
            this.cbAssunto.Items.AddRange(new object[] {
            "Melhoria na infraestrutura",
            "Contratação de serviços",
            "Eleição de diretoria",
            "Definição, modificação e ponderação sobre regras",
            "Outras"});
            this.cbAssunto.Location = new System.Drawing.Point(157, 42);
            this.cbAssunto.Name = "cbAssunto";
            this.cbAssunto.Size = new System.Drawing.Size(247, 21);
            this.cbAssunto.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID Reunião";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(30, 42);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 13;
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.AllowUserToOrderColumns = true;
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Location = new System.Drawing.Point(30, 240);
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.Size = new System.Drawing.Size(428, 147);
            this.dataLista.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Agendar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(474, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(474, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Consultar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(409, 221);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(102, 13);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "Total de Resultados";
            // 
            // frmReuniao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(567, 408);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataLista);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbAssunto);
            this.Controls.Add(this.txtResponsavel);
            this.Controls.Add(this.txtInformacoes);
            this.Controls.Add(this.dtReuniao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmReuniao";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmReuniao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource1)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtReuniao;
        private System.Windows.Forms.TextBox txtInformacoes;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource class1BindingSource;
        private System.Windows.Forms.BindingSource class1BindingSource1;
        private System.Windows.Forms.ComboBox cbAssunto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblTotal;
    }
}