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
    public partial class frmServico : Form
    {
        public frmServico()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmServico_Load(object sender, EventArgs e)
        {
          
        }

        private void Limpar()
        {
            this.txtOrdemS.Text = string.Empty;
            this.txtEmpresa.Text = string.Empty;
            this.txtServico.Text = string.Empty;
            this.txtNome.Text = string.Empty;
            this.dtExecucao.Text = string.Empty;
            this.txtDetalhes.Text = string.Empty;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                resp = NServicos.InseriOs(Convert.ToInt32(txtOrdemS.Text.Trim()),
                                               this.txtNome.Text.Trim(),
                                               this.txtServico.Text.Trim(),
                                               this.txtDetalhes.Text.Trim(),
                                               Convert.ToDateTime(dtExecucao.Text.Trim()));

                MessageBox.Show("Serviço Inserido com Sucesso!!");
                Limpar();

            }
            catch (Exception ex)
            {

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dataLista.DataSource = NServicos.ConsultaOs(Convert.ToInt32(txtOrdemS.Text));
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string resp = "";
            resp = NMorador.ExcluirMorador(Convert.ToInt32(txtOrdemS.Text));
            MessageBox.Show("Serviço Encerrado com Sucesso!!");
        }
    }
}
