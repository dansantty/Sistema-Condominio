using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DEmpresa
    {
        private int _idEmpresa;
        private string _cnpj;
        private string _nome;
        private string _endereco;
        private string _segmento;
        private string _nomeEmpresa;

        public int IdEmpresa
        {
            get
            {
                return _idEmpresa;
            }

            set
            {
                _idEmpresa = value;
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

        public string Endereco
        {
            get
            {
                return _endereco;
            }

            set
            {
                _endereco = value;
            }
        }

        public string Segmento
        {
            get
            {
                return _segmento;
            }

            set
            {
                _segmento = value;
            }
        }

        public string NomeEmpresa
        {
            get
            {
                return _nomeEmpresa;
            }

            set
            {
                _nomeEmpresa = value;
            }
        }

        public string Cnpj
        {
            get
            {
                return _cnpj;
            }

            set
            {
                _cnpj = value;
            }
        }

        

        //Construtor com parametros

        public DEmpresa(int idEmpresa, string nome, string cnpj, string endereco, string segmento, string nomeEmpresa)
        {
            this.IdEmpresa = idEmpresa;
            this.Nome = nome;
            this.Cnpj = cnpj;
            this.Endereco = endereco;
            this.Segmento = segmento;
            this.NomeEmpresa = nomeEmpresa;
        }

        public DEmpresa()
        {
        }

        //Metodo Inserir Empresa

        public string InserirEmpresa(DEmpresa Empresa)
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
                sqlCmd.CommandText = "inserirEmpresa";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdEmpresa = new SqlParameter();
                parIdEmpresa.ParameterName = "@idEmpresa";
                parIdEmpresa.SqlDbType = SqlDbType.Int;
                parIdEmpresa.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(parIdEmpresa);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 50;
                parNome.Value = Empresa.Nome;
                sqlCmd.Parameters.Add(parNome);

                SqlParameter parCnpj = new SqlParameter();
                parCnpj.ParameterName = "@cnpj";
                parCnpj.SqlDbType = SqlDbType.VarChar;
                parCnpj.Size = 20;
                parCnpj.Value = Empresa.Cnpj;
                sqlCmd.Parameters.Add(parCnpj);

                SqlParameter parEndereco = new SqlParameter();
                parEndereco.ParameterName = "@endereco";
                parEndereco.SqlDbType = SqlDbType.VarChar;
                parEndereco.Size = 70;
                parEndereco.Value = Empresa.Endereco;
                sqlCmd.Parameters.Add(parEndereco);

                SqlParameter parSegmento = new SqlParameter();
                parSegmento.ParameterName = "@segmento";
                parSegmento.SqlDbType = SqlDbType.VarChar;
                parSegmento.Size = 25;
                parSegmento.Value = Empresa.Segmento;
                sqlCmd.Parameters.Add(parSegmento);
                

                //executar comando

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Empresa Inserida" : "Empresa não inserida";



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

        //listar empresas

        public DataTable ListarEmpresa()
        {
            DataTable dtResultado = new DataTable("tbEmpresa");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("listarEmpresa", sqlCon);
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

        //buscar empresa

        public DataTable BuscarEmpresa(DEmpresa Empresa)
        {
            DataTable dtResultado = new DataTable("tbEmpresa");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "buscarEmpresa";
                sqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parNomeEmpresa = new SqlParameter();
                parNomeEmpresa.ParameterName = "@nome";
                parNomeEmpresa.SqlDbType = SqlDbType.VarChar;
                parNomeEmpresa.Size = 50;
                parNomeEmpresa.Value = Empresa.Nome;
                sqlCmd.Parameters.Add(parNomeEmpresa);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtResultado);
            }
            catch (Exception)
            {
                dtResultado = null;
            }
            return dtResultado;
        }
    }
}
