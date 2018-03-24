using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNegocio;
using System.Data;
using System.Data.OleDb;


namespace CamadaApresentacao
{
    public partial class frmCadastroMorador : Form
    {
        public frmCadastroMorador()
        {
            InitializeComponent();
        }

        private void MensagemOk(string mensagem)
        {
            MessageBox.Show(mensagem, "Sistema Condominio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Sistema Condominio", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpar()
        {
            this.txtNomeMorador.Text = string.Empty;
            this.txtCpf.Text = string.Empty;
            this.txtRg.Text = string.Empty;
            this.mskCel.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtApto.Text = string.Empty;
            this.txtUnidade.Text = string.Empty;
            this.txtId.Text = string.Empty;
        }

        //Mostrar 

        private void frmCadastroMorador_Load(object sender, EventArgs e)
        {
            dataLista.DataSource = NMorador.MostrarMoradores();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";

                resp = NMorador.InserirMorador(this.txtNomeMorador.Text.Trim(), Convert.ToInt32(txtCpf.Text.Trim()), Convert.ToInt32(txtRg.Text.Trim()), 
                    this.mskCel.Text.Trim(), this.txtEmail.Text.Trim(), this.txtUnidade.Text.Trim(), Convert.ToInt32(txtApto.Text.Trim()), Convert.ToDateTime(dateTimePicker1.Text.Trim()) );
                
                MessageBox.Show("Morador Inserido");
                Limpar();

            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataLista.DataSource = NMorador.MostrarMoradores();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           dataLista.DataSource = NMorador.BuscarMor(this.txtNomeMorador.Text);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string resp = "";
            resp = NMorador.ExcluirMorador(Convert.ToInt32(txtId.Text));
            MessageBox.Show("Morador Excluido");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";

                resp = NMorador.EditarMorador(Convert.ToInt32(txtId.Text.Trim()), this.txtNomeMorador.Text.Trim(), Convert.ToInt32(txtCpf.Text.Trim()), Convert.ToInt32(txtRg.Text.Trim()),
                    this.mskCel.Text.Trim(), this.txtEmail.Text.Trim(), this.txtUnidade.Text.Trim(), Convert.ToInt32(txtApto.Text.Trim()), Convert.ToDateTime(dateTimePicker1.Text.Trim()));

                MessageBox.Show("Morador Editado");
                Limpar();

            }
            catch (Exception ex)
            {

            }
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNomeMorador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
