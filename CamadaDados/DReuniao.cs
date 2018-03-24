using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DReuniao
    {
        private int _idReunioes;
        private string _assunto;
        private string _informacoes;
        private string _responsavel;
        private DateTime _data;

        public int IdReunioes
        {
            get
            {
                return _idReunioes;
            }

            set
            {
                _idReunioes = value;
            }
        }

        public string Assunto
        {
            get
            {
                return _assunto;
            }

            set
            {
                _assunto = value;
            }
        }

        public string Informacoes
        {
            get
            {
                return _informacoes;
            }

            set
            {
                _informacoes = value;
            }
        }

        public string Responsavel
        {
            get
            {
                return _responsavel;
            }

            set
            {
                _responsavel = value;
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
        public DReuniao()
        {

        }

        //Construtor com parametros
        public DReuniao(int idReunioes, string assunto, string informacoes, string responsavel, DateTime data)
        {
            this.IdReunioes = idReunioes;
            this.Assunto = assunto;
            this.Informacoes = informacoes;
            this.Responsavel = responsavel;
            this.Data = data;

        }

        //Agendar Reunião

        public string AgendaReuniao(DReuniao Reuniao)
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
                sqlCmd.CommandText = "agendaReuniao";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdMorador = new SqlParameter();
                parIdMorador.ParameterName = "@idReuniao";
                parIdMorador.SqlDbType = SqlDbType.Int;
                parIdMorador.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(parIdMorador);

                SqlParameter parAssunto = new SqlParameter();
                parAssunto.ParameterName = "@assunto";
                parAssunto.SqlDbType = SqlDbType.VarChar;
                parAssunto.Size = 50;
                parAssunto.Value = Reuniao.Assunto;
                sqlCmd.Parameters.Add(parAssunto);

                SqlParameter parInfo = new SqlParameter();
                parInfo.ParameterName = "@informacoes";
                parInfo.SqlDbType = SqlDbType.VarChar;
                parInfo.Size = 250;
                parInfo.Value = Reuniao.Informacoes;
                sqlCmd.Parameters.Add(parInfo);

                SqlParameter parResponsavel = new SqlParameter();
                parResponsavel.ParameterName = "@responsavel";
                parResponsavel.SqlDbType = SqlDbType.VarChar;
                parResponsavel.Size = 50;
                parResponsavel.Value = Reuniao.Responsavel;
                sqlCmd.Parameters.Add(parResponsavel);              

                SqlParameter parData = new SqlParameter();
                parData.ParameterName = "@data";
                parData.SqlDbType = SqlDbType.Date;
                parData.Value = Reuniao.Data;
                sqlCmd.Parameters.Add(parData);

                //executar comando

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Reuniao Inserido" : "Reuniao não inserido";



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

        // consulta reuniao

        public DataTable ConsultaReuniao(DReuniao Reuniao)
        {
            DataTable dtResultado = new DataTable("tbReunioes");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "consultaReuniao";
                sqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parAssunto = new SqlParameter();
                parAssunto.ParameterName = "@assunto";
                parAssunto.SqlDbType = SqlDbType.VarChar;
                parAssunto.Size = 50;
                parAssunto.Value = Reuniao.Assunto;
                sqlCmd.Parameters.Add(parAssunto);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtResultado);
            }
            catch (Exception)
            {
                dtResultado = null;
            }
            return dtResultado;
        }

        // cancelar / excluir reuniao

        public string CancelarReuniao(DReuniao Reuniao)
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
                sqlCmd.CommandText = "cancelarReuniao";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdReuniao = new SqlParameter();
                parIdReuniao.ParameterName = "@idReuniao";
                parIdReuniao.SqlDbType = SqlDbType.Int;
                parIdReuniao.Value = Reuniao.IdReunioes;
                sqlCmd.Parameters.Add(parIdReuniao);



                //executar comando

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Reuniao excluido" : "Reuniao não excluido";



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
