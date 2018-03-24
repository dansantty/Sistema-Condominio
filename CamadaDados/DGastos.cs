using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DGastos
    {
        private int _idEmitir;
        private int _idMorador;
        private decimal _gAgua;
        private decimal _gLuz;
        private decimal _gGas;
        private double _agua;
        private double _luz;
        private double _gas;
        private DateTime _vencimento;
        private int _cpf;

        public int IdEmitir
        {
            get
            {
                return _idEmitir;
            }

            set
            {
                _idEmitir = value;
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

        public decimal GAgua
        {
            get
            {
                return _gAgua;
            }

            set
            {
                _gAgua = value;
            }
        }

        public decimal GGas
        {
            get
            {
                return _gGas;
            }

            set
            {
                _gGas = value;
            }
        }

        public double Agua
        {
            get
            {
                return _agua;
            }

            set
            {
                _agua = value;
            }
        }

        public double Luz
        {
            get
            {
                return _luz;
            }

            set
            {
                _luz = value;
            }
        }

        public double Gas
        {
            get
            {
                return _gas;
            }

            set
            {
                _gas = value;
            }
        }

        public DateTime Vencimento
        {
            get
            {
                return _vencimento;
            }

            set
            {
                _vencimento = value;
            }
        }

        public decimal GLuz
        {
            get
            {
                return _gLuz;
            }

            set
            {
                _gLuz = value;
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

        public DGastos()
        {

        }

        public DGastos(int idEmitir, int idMorador, decimal gAgua, decimal gLuz, decimal gGas, 
            double agua, double luz, double gas, DateTime vencimento)
        {
            this.IdEmitir = idEmitir;
            this.IdMorador = idMorador;
            this.GAgua = gAgua;
            this.GLuz = gLuz;
            this.GGas = gGas;
            this.Agua = agua;
            this.Luz = luz;
            this.Gas = gas;
            this.Vencimento = vencimento;
        }

        public string InserirGastos(DGastos Gastos)
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
                sqlCmd.CommandText = "inserirGastos";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdEmitir = new SqlParameter();
                parIdEmitir.ParameterName = "@idEmitir";
                parIdEmitir.SqlDbType = SqlDbType.Int;
                parIdEmitir.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(parIdEmitir);

                SqlParameter parIdmorador = new SqlParameter();
                parIdmorador.ParameterName = "@idMorador";
                parIdmorador.SqlDbType = SqlDbType.Int;
                parIdmorador.Direction = ParameterDirection.Input;
                parIdmorador.Value = Gastos.IdMorador;
                sqlCmd.Parameters.Add(parIdmorador);

                SqlParameter pargAgua = new SqlParameter();
                pargAgua.ParameterName = "@gAgua";
                pargAgua.SqlDbType = SqlDbType.Decimal;
                pargAgua.Value = Gastos.GAgua;
                sqlCmd.Parameters.Add(pargAgua);

                SqlParameter pargLuz = new SqlParameter();
                pargLuz.ParameterName = "@gLuz";
                pargLuz.SqlDbType = SqlDbType.Decimal;
                pargLuz.Value = Gastos.GLuz;
                sqlCmd.Parameters.Add(pargLuz);

                SqlParameter pargGas = new SqlParameter();
                pargGas.ParameterName = "@gGas";
                pargGas.SqlDbType = SqlDbType.Decimal;
                pargGas.Value = Gastos.GGas;
                sqlCmd.Parameters.Add(pargGas);

                SqlParameter parAgua = new SqlParameter();
                parAgua.ParameterName = "@agua";
                parAgua.SqlDbType = SqlDbType.Money;
                parAgua.Value = Gastos.Agua;
                sqlCmd.Parameters.Add(parAgua);

                SqlParameter parLuz = new SqlParameter();
                parLuz.ParameterName = "@luz";
                parLuz.SqlDbType = SqlDbType.Money;
                parLuz.Value = Gastos.Luz;
                sqlCmd.Parameters.Add(parLuz);

                SqlParameter parGas = new SqlParameter();
                parGas.ParameterName = "@gas";
                parGas.SqlDbType = SqlDbType.Money;
                parGas.Value = Gastos.Gas;
                sqlCmd.Parameters.Add(parGas);

                SqlParameter parVencimento = new SqlParameter();
                parVencimento.ParameterName = "@vencimento";
                parVencimento.SqlDbType = SqlDbType.Date;
                parVencimento.Value = Gastos.Vencimento;
                sqlCmd.Parameters.Add(parVencimento);

                //executar comando

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Conta inserida" : "gasto não inserido";



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

        public DataTable EmitirGastos(DGastos Gastos)
        {
            DataTable dtResultado = new DataTable("tbEmitirGasto");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "EmitirFatura";
                sqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parCpfMorador = new SqlParameter();
                parCpfMorador.ParameterName = "@cpf";
                parCpfMorador.SqlDbType = SqlDbType.Int;
                parCpfMorador.Value = Gastos.Cpf;
                sqlCmd.Parameters.Add(parCpfMorador);

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
