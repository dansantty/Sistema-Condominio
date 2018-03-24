using System;
using System.Windows.Forms;
using CamadaDados;
using CamadaWeb;

namespace CamadaApresentacao
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCriarLogin frm = new frmCriarLogin();
            frm.ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DLogin log = new DLogin();

            // Todo: Refatorar metodo

            var ola = log.RealizaLogin(txtUsuario.Text, txtSenha.Text);

            if (!ola)
            {

                MessageBox.Show("Usuário incorreto ou não cadastrado na base de dados.");
            }
            else
            {
                // MessageBox.Show("Usuário Logado com sucesso!");
                Visible = false;
                frmMenu frmMenu = new frmMenu();
                frmMenu.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Usuário Logado com sucesso!");
            frmAlterarSenha frmNova = new frmAlterarSenha();
            frmNova.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
