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

namespace CamadaApresentacao
{
    public partial class frmInserirConsumo : Form
    {
        public frmInserirConsumo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void frmInserirConsumo_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";

                resp = NGastos.InserirGastos(Convert.ToInt32(txtID.Text.Trim()),Convert.ToDecimal(txtValorA.Text.Trim()),
                    Convert.ToDecimal(txtValorL.Text.Trim()), Convert.ToDecimal(txtValorG.Text.Trim()),Convert.ToDouble(txtQntA.Text.Trim()), 
                    Convert.ToDouble(txtQntL.Text.Trim()), Convert.ToDouble(txtQntG.Text.Trim()),Convert.ToDateTime(dtVencimento.Text.Trim()));
                MessageBox.Show("Contas Inseridas");
                
            }
            catch (Exception ex)
            {

            }
        }
    }
}
