using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
   public class DServicos
    {
        private int _idOrdem;
        private int _idEmpresa;
        private string _nomeSolicitante;
        private string _tipoServico;
        private string _detalhes;
        private DateTime _data;

        public int IdOrdem
        {
            get
            {
                return _idOrdem;
            }

            set
            {
                _idOrdem = value;
            }
        }

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

        public string NomeSolicitante
        {
            get
            {
                return _nomeSolicitante;
            }

            set
            {
                _nomeSolicitante = value;
            }
        }

        public string TipoServico
        {
            get
            {
                return _tipoServico;
            }

            set
            {
                _tipoServico = value;
            }
        }

        public string Detalhes
        {
            get
            {
                return _detalhes;
            }

            set
            {
                _detalhes = value;
            }
        }

        public DateTime Data
        {
            get
            {
                return _data;
            }

            set
            {
                _data = value;
            }
        }

        //Construtor Vazio
        public DServicos()
        {

        }

        //Construtor com parametros
        public DServicos(int idOrdem, int idEmpresa, string nomeSolicitante, string tipoServico, string detalhes, DateTime data)
        {
            this.IdOrdem = idOrdem;
            this.IdEmpresa = idEmpresa;
            this.NomeSolicitante = nomeSolicitante;
            this.TipoServico = tipoServico;
            this.Detalhes = detalhes;
            this.Data = data;
        }

        // incluir OS

        public string InserirOs(DServicos OS)
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
                sqlCmd.CommandText = "inserirOs";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdOs = new SqlParameter();
                parIdOs.ParameterName = "@idOrdem";
                parIdOs.SqlDbType = SqlDbType.Int;
                parIdOs.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(parIdOs);

                SqlParameter parIdEmpresa = new SqlParameter();
                parIdEmpresa.ParameterName = "@idempresa";
                parIdEmpresa.SqlDbType = SqlDbType.Int;
                parIdEmpresa.Value = OS.IdEmpresa;
                parIdEmpresa.Direction = ParameterDirection.Input;
                sqlCmd.Parameters.Add(parIdEmpresa);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 50;
                parNome.Value = OS.NomeSolicitante;
                sqlCmd.Parameters.Add(parNome);

                SqlParameter parTServico = new SqlParameter();
                parTServico.ParameterName = "@tipoServico";
                parTServico.SqlDbType = SqlDbType.VarChar;
                parTServico.Size = 50;
                parTServico.Value = OS.TipoServico;
                sqlCmd.Parameters.Add(parTServico);

                SqlParameter parDetalhes = new SqlParameter();
                parDetalhes.ParameterName = "@detalhes";
                parDetalhes.SqlDbType = SqlDbType.VarChar;
                parDetalhes.Size = 150;
                parDetalhes.Value = OS.Detalhes;
                sqlCmd.Parameters.Add(parDetalhes);

                SqlParameter parData = new SqlParameter();
                parData.ParameterName = "@data";
                parData.SqlDbType = SqlDbType.DateTime;
                parData.Value = OS.Data;
                sqlCmd.Parameters.Add(parData);

                //executar comando

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Serviço Inserido" : "Serviço não inserido";



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

        //consulta OS 

        public DataTable ConsultaOs(DServicos OS)
        {
            DataTable dtResultado = new DataTable("tbServicoO");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "consultarOS";
                sqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter paridOrdem = new SqlParameter();
                paridOrdem.ParameterName = "@idOs";
                paridOrdem.SqlDbType = SqlDbType.Int;
                paridOrdem.Value = OS.IdOrdem;
                sqlCmd.Parameters.Add(paridOrdem);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtResultado);
            }
            catch (Exception)
            {
                dtResultado = null;
            }
            return dtResultado;
        }

        //encerrar Os

        public string EncerrarOs(DServicos OS)
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
                sqlCmd.CommandText = "excluirOs";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdOrdem = new SqlParameter();
                parIdOrdem.ParameterName = "@idOrdem";
                parIdOrdem.SqlDbType = SqlDbType.Int;
                parIdOrdem.Value = OS.IdOrdem;
                sqlCmd.Parameters.Add(parIdOrdem);



                //executar comando

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "OS excluido" : "Os não excluido";



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
