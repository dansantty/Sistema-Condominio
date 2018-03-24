using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaDados;
using System.Data.OleDb;
using CamadaNegocio;


namespace CamadaApresentacao
{
    public partial class frmAlterarSenha : Form
    {
        public frmAlterarSenha()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            this.txtUsuario.Text = string.Empty;
            this.txtNovaSenha.Text = string.Empty;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            string resp = "";
            try
            {

                resp = NLogin.AlterarSenha(this.txtUsuario.Text.Trim(),
                                      this.txtNovaSenha.Text.Trim()
                                      );

                MessageBox.Show("Senha Alterada com Sucesso!!");

                this.Close();

            }
            catch (Exception ex)
            {

            }

        }

        private void frmAlterarSenha_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 