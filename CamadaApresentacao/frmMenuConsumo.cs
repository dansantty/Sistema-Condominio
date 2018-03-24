using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaApresentacao
{
    public partial class frmMenuConsumo : Form
    {
        public frmMenuConsumo()
        {
            InitializeComponent();
        }

        private void frmMenuConsumo_Load(object sender, EventArgs e)
        {

        }

        private void btnEmitirConsumo_Click(object sender, EventArgs e)
        {
            frmEmitirConsumo frmEmCons = new frmEmitirConsumo();
            frmEmCons.Show();
        }

        private void btnInserirConsumo_Click(object sender, EventArgs e)
        {
            frmInserirConsumo frmInCons = new frmInserirConsumo();
            frmInCons.Show();
        }
    }
}
