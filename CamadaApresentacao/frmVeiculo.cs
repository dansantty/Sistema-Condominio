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
    public partial class frmVeiculo : Form
    {
      

        public frmVeiculo()
        {
            InitializeComponent();
        }

        private void frmVeiculos_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try { 
            string resp = "";

            resp = NVeiculos.InserirVeiculo(Convert.ToInt32(txtIdMorador.Text.Trim()), this.txtPlaca.Text.Trim(), this.txtVeiculo.Text.Trim(), Convert.ToInt32(txtAno.Text.Trim()));

                MessageBox.Show("Veiculos Inserido");

            }catch(Exception ex)
            {
               
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvVeiculos.DataSource = NVeiculos.BuscarVeiculo(this.txtPlaca.Text.Trim());
        }

        private void nVeiculosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string resp = "";
            resp = NVeiculos.ExcluirVeiculo(Convert.ToInt32(txtIdVeiculo.Text));
            MessageBox.Show("Veiculo Excluido");
        }
    }
}
