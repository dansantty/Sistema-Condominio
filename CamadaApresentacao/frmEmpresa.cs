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
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Limpar()
        {
            this.txtIDEmpresa.Text = string.Empty;
            this.txtCNPJ.Text = string.Empty;
            this.txtNome.Text = string.Empty;
            this.txtEndereco.Text = string.Empty;
            this.txtSegmento.Text = string.Empty;
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
           
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {

                string resp = "";
                resp = NEmpresa.InserirEmpresa(this.txtNome.Text.Trim(), this.txtCNPJ.Text.Trim(), this.txtEndereco.Text.Trim(), this.txtSegmento.Text.Trim());
                MessageBox.Show("Empresa Inserida com sucesso!!");
                Limpar();

            }
            catch (Exception ex)
            {

            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataLista.DataSource = NEmpresa.ListarEmpresa();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataLista.DataSource = NEmpresa.BuscarEmpresa(this.txtNome.Text);
        }

    }
}
