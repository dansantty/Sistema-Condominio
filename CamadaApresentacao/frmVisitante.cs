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
    public partial class frmVisitante : Form
    {
        public frmVisitante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmVisitante_Load(object sender, EventArgs e)
        {

        }

        private void Limpar()
        {
            this.txtNome.Text = string.Empty;
            this.txtRG.Text = string.Empty;
            this.dtVisita.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataLista.DataSource = NVisitante.ConsultaVisitante((Convert.ToInt32(txtRG.Text)));
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";

                resp = NVisitante.InserirVisitante(this.txtNome.Text.Trim(),
                                                   Convert.ToInt32(txtRG.Text.Trim())
                                                   );

                MessageBox.Show("Visitante Inserido com Sucesso!! ");
                Limpar();

            }
            catch (Exception ex)
            {

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            // FALTOU ADICIONAR NA CAMADA DE NEGOCIO ESSA AÇÃO

           /*  
               string resp = "";
               resp = NVisitante.ExcluirVisitante(Convert.ToInt32(txtId.Text));
               MessageBox.Show("Visitante Excluido com sucesso");
           */
        }

        private void btnRenomear_Click(object sender, EventArgs e)
        {
        // FALTOU CRIAR ESTA AÇÃO NA CAMADA DE NEGOCIO

           /* try
            {
                string resp = "";
                resp = NVisitante.ModificarVisitante(Convert.ToInt32(txtRG.Text.Trim()),
                                                     this.txtNome.Text.Trim()),
                MessageBox.Show("Visitante Alterado com Sucesso");
                Limpar();
            }
            catch (Exception ex)
            {

            }
            */
        }
    }
}
