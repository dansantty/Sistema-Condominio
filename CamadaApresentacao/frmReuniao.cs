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
    public partial class frmReuniao : Form
    {
        public frmReuniao()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmReuniao_Load(object sender, EventArgs e)
        {
            
        }

        private void Limpar()
        {
            this.txtID.Text = string.Empty;
            this.cbAssunto.Text = string.Empty;
            this.txtResponsavel.Text = string.Empty;
            this.dtReuniao.Text = string.Empty;
            this.txtInformacoes.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";

                resp = NReuniao.AgendaReuniao(this.cbAssunto.Text.Trim(),
                                              this.txtInformacoes.Text.Trim(),
                                              this.txtResponsavel.Text.Trim(),
                                              Convert.ToDateTime(dtReuniao.Text.Trim())
                                              );

                MessageBox.Show("Reunião Agendada com sucesso !!");
                Limpar();
   
            }
            catch (Exception ex)
            {

            }
        }

        private void dtReuniao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataLista.DataSource = NReuniao.ConsultaReuniao(this.cbAssunto.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string resp = "";
            resp = NReuniao.ExcluirReuniao(Convert.ToInt32(this.txtID.Text));
            MessageBox.Show("Reunião Cancelada com sucesso!!");
        }
    }
}
