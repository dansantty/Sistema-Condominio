using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
   public class DReserva
    {
        private int _idReserva;
        private string _area;
        private DateTime _data;
        private int _idMorador;

        public int IdReserva
        {
            get
            {
                return _idReserva;
            }

            set
            {
                _idReserva = value;
            }
        }

        public string Area
        {
            get
            {
                return _area;
            }

            set
            {
                _area = value;
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
        public DReserva()
        {

        }

        //conmstrutor com parametros

        public DReserva(int idReserva, string area, DateTime data, int idMorador)
        {
            this.IdReserva = idReserva;
            this.Area = area;
            this.Data = data;
            this.IdMorador = idMorador;
        }

        // incluir reserva

        public string IncluirReserva(DReserva Reserva)

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
                sqlCmd.CommandText = "inserirReserva";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdReserva = new SqlParameter();
                parIdReserva.ParameterName = "@idReserva";
                parIdReserva.SqlDbType = SqlDbType.Int;
                parIdReserva.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(parIdReserva);

                SqlParameter parIdMorador = new SqlParameter();
                parIdMorador.ParameterName = "@idMorador";
                parIdMorador.SqlDbType = SqlDbType.Int;
                parIdMorador.Direction = ParameterDirection.Input;
                parIdMorador.Value = Reserva.IdMorador;
                sqlCmd.Parameters.Add(parIdMorador);

                SqlParameter parArea = new SqlParameter();
                parArea.ParameterName = "@area";
                parArea.SqlDbType = SqlDbType.VarChar;
                parArea.Size = 25;
                parArea.Value = Reserva.Area;
                sqlCmd.Parameters.Add(parArea);

                SqlParameter parData = new SqlParameter();
                parData.ParameterName = "@data";
                parData.SqlDbType = SqlDbType.DateTime;
                parData.Value = Reserva.Data;
                sqlCmd.Parameters.Add(parData);

               
                //executar comando

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Reserva Inserido" : "Reserva não inserido";



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

        //consultar reserva 

        public DataTable ConsultaReserva(DReserva Reserva)
        {
            DataTable dtResultado = new DataTable("tbReservas");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "consultarReserva";
                sqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parReserva = new SqlParameter();
                parReserva.ParameterName = "@idReserva";
                parReserva.SqlDbType = SqlDbType.Int;
                parReserva.Value = Reserva.IdReserva;
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

        //excluir reserva

        public string ExcluirReserva(DReserva Reserva)
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
                sqlCmd.CommandText = "excluirReserva";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdMorador = new SqlParameter();
                parIdMorador.ParameterName = "@idreserva";
                parIdMorador.SqlDbType = SqlDbType.Int;
                parIdMorador.Value = Reserva.IdReserva;
                sqlCmd.Parameters.Add(parIdMorador);



                //executar comando

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Reserva excluido" : "Reserva não excluido";



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
