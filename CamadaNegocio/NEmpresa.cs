using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;


namespace CamadaNegocio
{
    public class NEmpresa
    {
        //Inserir 

        public static string InserirEmpresa(string nome, string cnpj, string endereco, string segmento)
        {
            DEmpresa Obj = new CamadaDados.DEmpresa();

            Obj.Cnpj = cnpj;
            Obj.Nome = nome;
            Obj.Endereco = endereco;
            Obj.Segmento = segmento;

            return Obj.InserirEmpresa(Obj);
        }

        //listar Empresa

        public static DataTable ListarEmpresa()
        {
            return new DEmpresa().ListarEmpresa();
        }

        //buscar empresa
        public static DataTable BuscarEmpresa(string nome)
        {
            DEmpresa Obj = new DEmpresa();
            Obj.Nome = nome;
            return Obj.BuscarEmpresa(Obj);
        }

    }
}
