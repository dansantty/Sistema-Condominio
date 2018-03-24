using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
   public class DMorador
    {
        private int _idMorador;
        private string _nome;
        private int _cpf;
        private int _rg;
        private string _celular;
        private string _email;
        private string _unidade;
        private int _apto;
        private DateTime _dataEntrada;
        private string _mostrarMorador;

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

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
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

        public int Rg
        {
            get
            {
                return _rg;
            }

            set
            {
                _rg = value;
            }
        }

        public string Celular
        {
            get
            {
                return _celular;
            }

            set
            {
                _celular = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string Unidade
        {
            get
            {
                return _unidade;
            }

            set
            {
                _unidade = value;
            }
        }

        public int Apto
        {
            get
            {
                return _apto;
            }

            set
            {
                _apto = value;
            }
        }

        public DateTime DataEntrada
        {
            get
            {
                return _dataEntrada;
            }

            set
            {
                _dataEntrada = value;
            }
        }

        public string MostrarMorador
        {
            get
            {
                return _mostrarMorador;
            }

            set
            {
                _mostrarMorador = value;
            }
        }

        //Construtor Vazio
        public DMorador()
        {

        }

        //Construtor com parametros

        public DMorador(int idMorador, string nome, int cpf, int rg, string celular, string email, string unidade,
            int apto, DateTime dataEntrada, string mostraMorador)
        {
            this.IdMorador = idMorador;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Rg = rg;
            this.Celular = celular;
            this.Email = email;
            this.Unidade = unidade;
            this.Apto = apto;
            this.DataEntrada = dataEntrada;
            this.MostrarMorador = mostraMorador;
        }

                //metodo inserir morador

             public string InserirMorador(DMorador Morador)
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
                sqlCmd.CommandText = "inserirMorador";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdMorador = new SqlParameter();
                parIdMorador.ParameterName = "@idMorador";
                parIdMorador.SqlDbType = SqlDbType.Int;
                parIdMorador.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(parIdMorador);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 60;
                parNome.Value = Morador.Nome;
                sqlCmd.Parameters.Add(parNome);

                SqlParameter parCpf = new SqlParameter();
                parCpf.ParameterName = "@cpf";
                parCpf.SqlDbType = SqlDbType.Int;
                parCpf.Value = Morador.Cpf;
                sqlCmd.Parameters.Add(parCpf);

                SqlParameter parRg = new SqlParameter();
                parRg.ParameterName = "@rg";
                parRg.SqlDbType = SqlDbType.Int;
                parRg.Value = Morador.Rg;
                sqlCmd.Parameters.Add(parRg);

                SqlParameter parCelular = new SqlParameter();
                parCelular.ParameterName = "@celular";
                parCelular.SqlDbType = SqlDbType.VarChar;
                parCelular.Size = 20;
                parCelular.Value = Morador.Celular;
                sqlCmd.Parameters.Add(parCelular);

                SqlParameter parEmail = new SqlParameter();
                parEmail.ParameterName = "@email";
                parEmail.SqlDbType = SqlDbType.VarChar;
                parEmail.Size = 75;
                parEmail.Value = Morador.Email;
                sqlCmd.Parameters.Add(parEmail);

                SqlParameter parUnidade = new SqlParameter();
                parUnidade.ParameterName = "@unidade";
                parUnidade.SqlDbType = SqlDbType.VarChar;
                parUnidade.Size = 30;
                parUnidade.Value = Morador.Unidade;
                sqlCmd.Parameters.Add(parUnidade);

                SqlParameter parApto = new SqlParameter();
                parApto.ParameterName = "@apto";
                parApto.SqlDbType = SqlDbType.Int;
                parApto.Value = Morador.Apto;
                sqlCmd.Parameters.Add(parApto);

                SqlParameter parDataEntrada = new SqlParameter();
                parDataEntrada.ParameterName = "@dataEntrada";
                parDataEntrada.SqlDbType = SqlDbType.Date;
                parDataEntrada.Value = Morador.DataEntrada;
                sqlCmd.Parameters.Add(parDataEntrada);

                //executar comando

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Morador Inserido" : "Morador não inserido";
               
                

            }
            catch(Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if(sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
            }
            return resp;
        }

        //editar morador

        public string EditarMorador(DMorador Morador)
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
                sqlCmd.CommandText = "modificarMorador";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdMorador = new SqlParameter();
                parIdMorador.ParameterName = "@idMorador";
                parIdMorador.SqlDbType = SqlDbType.Int;
                parIdMorador.Value = Morador.IdMorador;
                sqlCmd.Parameters.Add(parIdMorador);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 60;
                parNome.Value = Morador.Nome;
                sqlCmd.Parameters.Add(parNome);

                SqlParameter parCpf = new SqlParameter();
                parCpf.ParameterName = "@cpf";
                parCpf.SqlDbType = SqlDbType.Int;
                parCpf.Value = Morador.Cpf;
                sqlCmd.Parameters.Add(parCpf);

                SqlParameter parRg = new SqlParameter();
                parRg.ParameterName = "@rg";
                parRg.SqlDbType = SqlDbType.Int;
                parRg.Value = Morador.Rg;
                sqlCmd.Parameters.Add(parRg);

                SqlParameter parCelular = new SqlParameter();
                parCelular.ParameterName = "@celular";
                parCelular.SqlDbType = SqlDbType.VarChar;
                parCelular.Size = 20;
                parCelular.Value = Morador.Celular;
                sqlCmd.Parameters.Add(parCelular);

                SqlParameter parEmail = new SqlParameter();
                parEmail.ParameterName = "@email";
                parEmail.SqlDbType = SqlDbType.VarChar;
                parEmail.Size = 75;
                parEmail.Value = Morador.Email;
                sqlCmd.Parameters.Add(parEmail);

                SqlParameter parUnidade = new SqlParameter();
                parUnidade.ParameterName = "@unidade";
                parUnidade.SqlDbType = SqlDbType.VarChar;
                parUnidade.Size = 30;
                parUnidade.Value = Morador.Unidade;
                sqlCmd.Parameters.Add(parUnidade);

                SqlParameter parApto = new SqlParameter();
                parApto.ParameterName = "@apto";
                parApto.SqlDbType = SqlDbType.Int;
                parApto.Value = Morador.Apto;
                sqlCmd.Parameters.Add(parApto);

                SqlParameter parDataEntrada = new SqlParameter();
                parDataEntrada.ParameterName = "@dataEntrada";
                parDataEntrada.SqlDbType = SqlDbType.Date;
                parDataEntrada.Value = Morador.DataEntrada;
                sqlCmd.Parameters.Add(parDataEntrada);

                //executar comando

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Morador Alterado" : "Morador não alterado";



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

        //Excluir Morador

        public string ExcluirMorador(DMorador Morador)
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
                sqlCmd.CommandText = "excluirMorador";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdMorador = new SqlParameter();
                parIdMorador.ParameterName = "@idMorador";
                parIdMorador.SqlDbType = SqlDbType.Int;
                parIdMorador.Value = Morador.IdMorador;
                sqlCmd.Parameters.Add(parIdMorador);

                

                //executar comando

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Morador excluido" : "Morador não excluido";



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

        //mostrar moradores

            public DataTable MostrarM()
        {
            DataTable dtResultado = new DataTable ("tbMorador");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("mostrarMorador", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sqlDat = sqlCmd.ExecuteReader();
                dtResultado.Load(sqlDat);
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                dtResultado = null;
            }
            return dtResultado;
        }

        //buscar morador

         public DataTable BuscarMorador(DMorador Morador)
        {
            DataTable dtResultado = new DataTable("tbMorador");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "buscarNome";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                

                SqlParameter parNomeMorador = new SqlParameter();
                parNomeMorador.ParameterName = "@textoBusca";
                parNomeMorador.SqlDbType = SqlDbType.VarChar;
                parNomeMorador.Size = 50;
                parNomeMorador.Value = Morador.MostrarMorador;
                sqlCmd.Parameters.Add(parNomeMorador);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtResultado);
            }
            catch (Exception )
            {
                dtResultado = null;
            }
            return dtResultado;
        }

    }
}
