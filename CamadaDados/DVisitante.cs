using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DVisitante
    {
        private int _idVisitante;
        private string _nomeVisitante;
        private int _rgVisitante;

        public int IdVisitante
        {
            get
            {
                return _idVisitante;
            }

            set
            {
                _idVisitante = value;
            }
        }

        public string NomeVisitante
        {
            get
            {
                return _nomeVisitante;
            }

            set
            {
                _nomeVisitante = value;
            }
        }

        public int RgVisitante
        {
            get
            {
                return _rgVisitante;
            }

            set
            {
                _rgVisitante = value;
            }
        }

        //Construtor Vazio
        public DVisitante()
        {

        }

        //Construtor com Parametros

        public DVisitante(int idVisitante, string nomeVisitante, int rgVisitante)
        {
            this.IdVisitante = idVisitante;
            this.NomeVisitante = nomeVisitante;
            this.RgVisitante = rgVisitante;
        }

        //Incluir Visitante

        public string IncluirVisitante(DVisitante Visitante)

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
                sqlCmd.CommandText = "inserirVisitante";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdVisitante = new SqlParameter();
                parIdVisitante.ParameterName = "@idVisitante";
                parIdVisitante.SqlDbType = SqlDbType.Int;
                parIdVisitante.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(parIdVisitante);

                SqlParameter parRg = new SqlParameter();
                parRg.ParameterName = "@rg";
                parRg.SqlDbType = SqlDbType.Int;
                parRg.Value = Visitante.RgVisitante;
                sqlCmd.Parameters.Add(parRg);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 60;
                parNome.Value = Visitante.NomeVisitante;
                sqlCmd.Parameters.Add(parNome);

         


                //executar comando

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Visitante Inserido" : "Visitante não inserido";



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

        //Buscar Visitante

        public DataTable ConsultaVisitante(DVisitante Visitante)
        {
            DataTable dtResultado = new DataTable("tbVisitante");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "buscarVisitante";
                sqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parReserva = new SqlParameter();
                parReserva.ParameterName = "@rg";
                parReserva.SqlDbType = SqlDbType.Int;
                parReserva.Value = Visitante.RgVisitante;
                sqlCmd.Parameters.Add(parReserva);

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
