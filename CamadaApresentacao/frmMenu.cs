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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            frmCadastroMorador frmMor = new frmCadastroMorador();
            frmMor.ShowDialog();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            //this.Visible = false;
            frmServico frmServ = new frmServico();
            frmServ.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            //this.Visible = false;
            frmMenuConsumo frmCons = new frmMenuConsumo();
            frmCons.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //this.Visible = false;
            frmUnidade frmUni = new frmUnidade();
            frmUni.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //this.Visible = false;
            frmVeiculo frmVei = new frmVeiculo();
            frmVei.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //this.Visible = false;
            frmVisitante frmVist = new frmVisitante();
            frmVist.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            frmEmpresa frmEmpre = new frmEmpresa();
            frmEmpre.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //this.Visible = false;
            frmReuniao frmReu = new frmReuniao();
            frmReu.ShowDialog();
        }
    }
}
