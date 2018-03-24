using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DLogin
    {
        private int _idLogin;
        private int _cpf;
        private string _usuario;
        private string _senha;
        private string _tipoUsuario;
        private int _idMorador;

        public int IdLogin
        {
            get
            {
                return _idLogin;
            }

            set
            {
                _idLogin = value;
            }
        }

        public int Cpf
        {
            get
            {
                return _cpf;
            }

            set
            {
                _cpf = value;
            }
        }

        public string Usuario
        {
            get
            {
                return _usuario;
            }

            set
            {
                _usuario = value;
            }
        }

        public string Senha
        {
            get
            {
                return _senha;
            }

            set
            {
                _senha = value;
            }
        }

        public string TipoUsuario
        {
            get
            {
                return _tipoUsuario;
            }

            set
            {
                _tipoUsuario = value;
            }
        }

        public int IdMorador
        {
            get
            {
                return _idMorador;
            }

            set
            {
                _idMorador = value;
            }
        }

        //Construtor Vazio
        public DLogin()
        {

        }

        //Construtor com parametro

        public DLogin(int idLogin, int cpf, string usuario, string senha, string tipoUsuario, int idMorador)
        {
            this.IdLogin = idLogin;
            this.Cpf = cpf;
            this.Usuario = usuario;
            this.Senha = senha;
            this.TipoUsuario = tipoUsuario;
            this.IdMorador = idMorador;
        }

        //metodo inserir morador

        public string InserirLogin(DLogin Login)
        {
            string resp = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                //codigo
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "inserirLogin";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdLogin = new SqlParameter();
                parIdLogin.ParameterName = "@idLogin";
                parIdLogin.SqlDbType = SqlDbType.Int;
                parIdLogin.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(parIdLogin);

                SqlParameter parIdmorador = new SqlParameter();
                parIdmorador.ParameterName = "@idMorador";
                parIdmorador.SqlDbType = SqlDbType.Int;
                parIdmorador.Direction = ParameterDirection.Input;
                parIdmorador.Value = Login.IdMorador;
                sqlCmd.Parameters.Add(parIdmorador);

                SqlParameter parCpf = new SqlParameter();
                parCpf.ParameterName = "@cpf";
                parCpf.SqlDbType = SqlDbType.Int;
                parCpf.Value = Login.Cpf;
                sqlCmd.Parameters.Add(parCpf);

                SqlParameter parUsuario = new SqlParameter();
                parUsuario.ParameterName = "@usuario";
                parUsuario.SqlDbType = SqlDbType.VarChar;
                parUsuario.Size = 15;
                parUsuario.Value = Login.Usuario;
                sqlCmd.Parameters.Add(parUsuario);

                SqlParameter parSenha = new SqlParameter();
                parSenha.ParameterName = "@senha";
                parSenha.SqlDbType = SqlDbType.VarChar;
                parSenha.Size = 8;
                parSenha.Value = Login.Senha;
                sqlCmd.Parameters.Add(parSenha);

                SqlParameter parTUsuario = new SqlParameter();
                parTUsuario.ParameterName = "@tipoUsuario";
                parTUsuario.SqlDbType = SqlDbType.VarChar;
                parTUsuario.Size = 15;
                parTUsuario.Value = Login.TipoUsuario;
                sqlCmd.Parameters.Add(parTUsuario);

                //executar comando

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Login Inserido" : "Login não inserido";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return resp;
        }

        public bool RealizaLogin(string login, string senha)
        {
            DataTable dtResultado = new DataTable();

            SqlConnection sqlCon = new SqlConnection();

            sqlCon.ConnectionString = Conexao.Cn;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandText = "realizaLogin";
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parLogin = new SqlParameter();
            parLogin.ParameterName = "@login";
            parLogin.SqlDbType = SqlDbType.VarChar;
            parLogin.Size = 15;
            parLogin.Value = login;
            sqlCmd.Parameters.Add(parLogin);

            SqlParameter parSenha = new SqlParameter();
            parSenha.ParameterName = "@senha";
            parSenha.SqlDbType = SqlDbType.VarChar;
            parSenha.Size = 8;
            parSenha.Value = senha;
            sqlCmd.Parameters.Add(parSenha);

            SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
            sqlDat.Fill(dtResultado);

            sqlCon.Close();

            if (dtResultado.Rows.Count > 0)
                return true;
            else
                return false;
        }

        //Alterar Senha

        public string AlterarSenha(DLogin Login)
        {
            string resp = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                //codigo
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "alterarSenha";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parUsuario = new SqlParameter();
                parUsuario.ParameterName = "@usuario";
                parUsuario.SqlDbType = SqlDbType.VarChar;
                parUsuario.Size = 15;
                parUsuario.Value = Login.Usuario;
                sqlCmd.Parameters.Add(parUsuario);

                SqlParameter parSenha = new SqlParameter();
                parSenha.ParameterName = "@senha";
                parSenha.SqlDbType = SqlDbType.VarChar;
                parSenha.Size = 8;
                parSenha.Value = Login.Senha;
                sqlCmd.Parameters.Add(parSenha);

                //executar comando

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Senha Alterada" : "Não Alterada";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return resp;
        }

    }

}
