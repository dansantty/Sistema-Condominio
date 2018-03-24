namespace CamadaApresentacao
{
    partial class frmCadastroMorador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroMorador));
            this.lblNomeMorador = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.lblApto = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.mskCel = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeMorador = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApto = new System.Windows.Forms.TextBox();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeMorador
            // 
            this.lblNomeMorador.AutoSize = true;
            this.lblNomeMorador.Location = new System.Drawing.Point(12, 23);
            this.lblNomeMorador.Name = "lblNomeMorador";
            this.lblNomeMorador.Size = new System.Drawing.Size(41, 13);
            this.lblNomeMorador.TabIndex = 0;
            this.lblNomeMorador.Text = "Nome: ";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(226, 23);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(33, 13);
            this.lblCpf.TabIndex = 1;
            this.lblCpf.Text = "CPF: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(226, 55);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email: ";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Location = new System.Drawing.Point(12, 55);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(45, 13);
            this.lblCel.TabIndex = 3;
            this.lblCel.Text = "Celular: ";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(448, 19);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(29, 13);
            this.lblRg.TabIndex = 4;
            this.lblRg.Text = "RG: ";
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Location = new System.Drawing.Point(9, 85);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(53, 13);
            this.lblUnidade.TabIndex = 5;
            this.lblUnidade.Text = "Unidade: ";
            // 
            // lblApto
            // 
            this.lblApto.AutoSize = true;
            this.lblApto.Location = new System.Drawing.Point(448, 55);
            this.lblApto.Name = "lblApto";
            this.lblApto.Size = new System.Drawing.Size(42, 13);
            this.lblApto.TabIndex = 6;
            this.lblApto.Text = "APTO: ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(226, 85);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "ID: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(451, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(448, 85);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(76, 13);
            this.lblDataEntrada.TabIndex = 9;
            this.lblDataEntrada.Text = "Data Entrada: ";
            // 
            // mskCel
            // 
            this.mskCel.Location = new System.Drawing.Point(68, 48);
            this.mskCel.Mask = "(99) 00000-0000";
            this.mskCel.Name = "mskCel";
            this.mskCel.Size = new System.Drawing.Size(100, 20);
            this.mskCel.TabIndex = 10;
            // 
            // txtNomeMorador
            // 
            this.txtNomeMorador.Location = new System.Drawing.Point(68, 16);
            this.txtNomeMorador.Name = "txtNomeMorador";
            this.txtNomeMorador.Size = new System.Drawing.Size(132, 20);
            this.txtNomeMorador.TabIndex = 11;
            this.txtNomeMorador.TextChanged += new System.EventHandler(this.txtNomeMorador_TextChanged);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(267, 16);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(113, 20);
            this.txtCpf.TabIndex = 12;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(483, 12);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(100, 20);
            this.txtRg.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(267, 48);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // txtApto
            // 
            this.txtApto.Location = new System.Drawing.Point(496, 48);
            this.txtApto.Name = "txtApto";
            this.txtApto.Size = new System.Drawing.Size(100, 20);
            this.txtApto.TabIndex = 15;
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(68, 78);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(100, 20);
            this.txtUnidade.TabIndex = 16;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(267, 78);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(57, 20);
            this.txtId.TabIndex = 17;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnSalvar.Location = new System.Drawing.Point(85, 148);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 23);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnExcluir.Location = new System.Drawing.Point(199, 148);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(98, 23);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnEditar.Location = new System.Drawing.Point(312, 148);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(98, 23);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "Atualizar Morador";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnBuscar.Location = new System.Drawing.Point(426, 148);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 23);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnListar.Location = new System.Drawing.Point(540, 148);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(98, 23);
            this.btnListar.TabIndex = 22;
            this.btnListar.Text = "Atualizar Lista";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(507, 192);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(99, 13);
            this.lblTotal.TabIndex = 23;
            this.lblTotal.Text = "Total de Moradores";
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.AllowUserToOrderColumns = true;
            this.dataLista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Location = new System.Drawing.Point(15, 208);
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(693, 297);
            this.dataLista.TabIndex = 24;
            this.dataLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(687, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "v1.0";
            // 
            // frmCadastroMorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(727, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataLista);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.txtApto);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNomeMorador);
            this.Controls.Add(this.mskCel);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblApto);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNomeMorador);
            this.Name = "frmCadastroMorador";
            this.Text = " Cadastro de Moradores";
            this.Load += new System.EventHandler(this.frmCadastroMorador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeMorador;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.Label lblApto;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.MaskedTextBox mskCel;
        private System.Windows.Forms.TextBox txtNomeMorador;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtApto;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dataLista;
//        private dbCondominioDataSetTableAdapters.mostrarMoradorTableAdapter mostrarMoradorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMoradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}