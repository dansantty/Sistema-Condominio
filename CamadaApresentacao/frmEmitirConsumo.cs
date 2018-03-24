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
    public partial class frmEmitirConsumo : Form
    {
        public frmEmitirConsumo()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void frmEmitirConsumo_Load(object sender, EventArgs e)
        {
            //dataGridEmitir.DataSource = NGastos.EmitirGastos(Convert.ToInt32(txtCPF.Text.Trim()));
        }

        private void btnBConta_Click(object sender, EventArgs e)
        {
            dataGridEmitir.DataSource = NGastos.EmitirGastos(Convert.ToInt32(txtCPF.Text.Trim()));
        }
    }
}
