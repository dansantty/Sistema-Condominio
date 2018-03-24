﻿using System;
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
    public partial class frmCriarLogin : Form
    {
        public frmCriarLogin()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string resp = "";
            try
            {

                resp = NLogin.InserirLogin(Convert.ToInt32(txtId.Text.Trim()), Convert.ToInt32(txtCpf.Text.Trim()), this.txtUsuario.Text.Trim(), this.txtSenha.Text.Trim(), this.txtTipo.Text.Trim());

                MessageBox.Show("Usuário inserido com sucesso");

                this.Close();

            }catch(Exception ex)
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmCriarLogin_Load(object sender, EventArgs e)
        {
           
        }
    }
}
