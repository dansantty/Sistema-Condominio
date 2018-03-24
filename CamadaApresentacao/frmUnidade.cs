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
using System.Data.OleDb;

namespace CamadaApresentacao
{
    public partial class frmUnidade : Form
    {
        public frmUnidade()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            this.txtID.Text = string.Empty;
            this.txtNome.Text = string.Empty;
            this.txtEndereco.Text = string.Empty;
            this.txtApartamentos.Text = string.Empty;
            this.txtApartamentosDisponveis.Text = string.Empty;
            this.txtInformacoes.Text = string.Empty;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUnidade_Load(object sender, EventArgs e)
        {
            dataLista.DataSource = NUnidades.ListarUnidades();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";

                resp = NUnidades.InserirUnidade(this.txtNome.Text.Trim(),
                                                this.txtEndereco.Text.Trim(),
                                                Convert.ToInt32(txtApartamentos.Text.Trim()),
                                                Convert.ToInt32(txtApartamentosDisponveis.Text.Trim()),
                                                this.txtInformacoes.Text.Trim());

                MessageBox.Show("Unidade Inserida com Sucesso!!");
                Limpar();

            }
            catch (Exception ex)
            {

            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataLista.DataSource = NUnidades.ListarUnidades();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // EXISTE UM ERRO AQUI NO PARAMETRO
            dataLista.DataSource = NUnidades.BuscarUnidade(Convert.ToInt32(txtID.Text));
        }
    }
}
