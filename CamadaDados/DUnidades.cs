using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CamadaDados
{
   public class DUnidades
    {
        private int _idUnidade;
        private string _nome;
        private string _endereco;
        private int _aptos;
        private int _aptosDisponiveis;
        private string _informacoes;

        public int IdUnidade
        {
            get
            {
                return _idUnidade;
            }

            set
            {
                _idUnidade = value;
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

        public int Aptos
        {
            get
            {
                return _aptos;
            }

            set
            {
                _aptos = value;
            }
        }

        public int AptosDisponiveis
        {
            get
            {
                return _aptosDisponiveis;
            }

            set
            {
                _aptosDisponiveis = value;
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

        //Construtor Vazio
        public DUnidades()
        {

        }

        //Construtor com parametro
        public DUnidades(int idUnidade, string nome, string endereco, int aptos, int aptosDisponiveis, string informacoes)
        {
            this.IdUnidade = idUnidade;
            this.Nome = nome;
            this.Endereco = endereco;
            this.Aptos = aptos;
            this.AptosDisponiveis = aptosDisponiveis;
            this.Informacoes = informacoes;
        }

        //Inserir Unidade
        public string InserirUnidade(DUnidades Unidades)
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
                sqlCmd.CommandText = "inserirUnidade";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdUnidade = new SqlParameter();
                parIdUnidade.ParameterName = "@idUnidade";
                parIdUnidade.SqlDbType = SqlDbType.Int;
                parIdUnidade.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(parIdUnidade);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 50;
                parNome.Value = Unidades.Nome;
                sqlCmd.Parameters.Add(parNome);

                SqlParameter parEndereco = new SqlParameter();
                parEndereco.ParameterName = "@endereco";
                parEndereco.SqlDbType = SqlDbType.VarChar;
                parEndereco.Size = 70;
                parEndereco.Value = Unidades.Endereco;
                sqlCmd.Parameters.Add(parEndereco);

                SqlParameter parAptos = new SqlParameter();
                parAptos.ParameterName = "@aptos";
                parAptos.SqlDbType = SqlDbType.Int;
                parAptos.Value = Unidades.Aptos;
                sqlCmd.Parameters.Add(parAptos);

                SqlParameter parAptosDisp = new SqlParameter();
                parAptosDisp.ParameterName = "@aptosDisponivel";
                parAptosDisp.SqlDbType = SqlDbType.Int;
                parAptosDisp.Value = Unidades.AptosDisponiveis;
                sqlCmd.Parameters.Add(parAptosDisp);

                SqlParameter parInformacoes = new SqlParameter();
                parInformacoes.ParameterName = "@informacoes";
                parInformacoes.SqlDbType = SqlDbType.VarChar;
                parInformacoes.Size = 200;
                parInformacoes.Value = Unidades.Informacoes;
                sqlCmd.Parameters.Add(parInformacoes);

                

                //executar comando

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Unidade Inserido" : "Unidade não inserido";



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

        //buscar unidade 

        public DataTable BuscarUnidades(DUnidades Unidades)
        {
            DataTable dtResultado = new DataTable("tbUnidades");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "buscarUnidade";
                sqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter paridUnidades = new SqlParameter();
                paridUnidades.ParameterName = "@idUnidade";
                paridUnidades.SqlDbType = SqlDbType.Int;
                paridUnidades.Value = Unidades.IdUnidade ;
                sqlCmd.Parameters.Add(paridUnidades);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtResultado);
            }
            catch (Exception)
            {
                dtResultado = null;
            }
            return dtResultado;
        }

        //Mostra unidades

        public DataTable ListarUnidades()
        {
            DataTable dtResultado = new DataTable("tbUnidades");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("listarUnidade", sqlCon);
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
    }
}
