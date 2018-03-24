using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DVeiculos
    {
        private int _idVeiculo;
        private int _idMorador;
        private string _placa;
        private string _nomeVeiculo;
        private int _ano;

        public int IdVeiculo
        {
            get
            {
                return _idVeiculo;
            }

            set
            {
                _idVeiculo = value;
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

        public string Placa
        {
            get
            {
                return _placa;
            }

            set
            {
                _placa = value;
            }
        }

        public string NomeVeiculo
        {
            get
            {
                return _nomeVeiculo;
            }

            set
            {
                _nomeVeiculo = value;
            }
        }

        public int Ano
        {
            get
            {
                return _ano;
            }

            set
            {
                _ano = value;
            }
        }

        //Construtor Vazio
        public DVeiculos()
        {

        }

        //Construtor com parametro
        public DVeiculos(int idVeiculo, int idMorador, string placa, string nomeVeiculo, int ano)
        {
            this.IdVeiculo = idVeiculo;
            this.IdMorador = idMorador;
            this.Placa = placa;
            this.NomeVeiculo = nomeVeiculo;
            this.Ano = ano;
        }

        //metodo inserir veiculo.

        public string InserirVeiculo(DVeiculos Veiculos)
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
                sqlCmd.CommandText = "inserirVeiculo";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdVeiculo = new SqlParameter();
                parIdVeiculo.ParameterName = "@idVeiculos";
                parIdVeiculo.SqlDbType = SqlDbType.Int;
                parIdVeiculo.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(parIdVeiculo);

                SqlParameter parIdMorador = new SqlParameter();
                parIdMorador.ParameterName = "@idMorador";
                parIdMorador.SqlDbType = SqlDbType.Int;
                parIdMorador.Direction = ParameterDirection.Input;
                parIdMorador.Value = Veiculos.IdMorador;
                sqlCmd.Parameters.Add(parIdMorador);

                SqlParameter parPlaca = new SqlParameter();
                parPlaca.ParameterName = "@placa";
                parPlaca.SqlDbType = SqlDbType.VarChar;
                parPlaca.Size = 50;
                parPlaca.Value = Veiculos.Placa;
                sqlCmd.Parameters.Add(parPlaca);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 50;
                parNome.Value = Veiculos.NomeVeiculo;
                sqlCmd.Parameters.Add(parNome);

                SqlParameter parAno = new SqlParameter();
                parAno.ParameterName = "@ano";
                parAno.SqlDbType = SqlDbType.Int;
                parAno.Value = Veiculos.Ano;
                sqlCmd.Parameters.Add(parAno);

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Veiculo Inserido" : "Veiculo não inserido";

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

        //Metodo buscar veiculos 
        public DataTable BuscarVeiculo(DVeiculos Veiculos)
        {
            DataTable dtResultado = new DataTable("tbVeiculos");
            SqlConnection sqlCon = new SqlConnection();
            

            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "buscarVeiculo";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parPlaca = new SqlParameter();
                parPlaca.ParameterName = "@placa";
                parPlaca.SqlDbType = SqlDbType.VarChar;
                parPlaca.Size = 50;
                parPlaca.Value = Veiculos.Placa;
                sqlCmd.Parameters.Add(parPlaca);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtResultado);

            }
            catch (Exception)
            {
                dtResultado = null;
            }
            return dtResultado;
        }


        //Metodo excluir veiculo
        public string ExcluirVeiculo(DVeiculos Veiculos)
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
                sqlCmd.CommandText = "excluirVeiculo";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdVeiculos = new SqlParameter();
                parIdVeiculos.ParameterName = "@idVeiculo";
                parIdVeiculos.SqlDbType = SqlDbType.Int;
                parIdVeiculos.Value = Veiculos.IdVeiculo;
                sqlCmd.Parameters.Add(parIdVeiculos);



                //executar comando

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Veiculo excluido" : "Veiculo não excluido";
                sqlCon.Close();

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            } return resp;
        }

    }
}
