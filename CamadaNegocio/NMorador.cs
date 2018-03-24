using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NMorador
    {
        //Inserir
        public static string InserirMorador(string nome, int cpf, int rg, string celular, string email, string unidade, int apto, DateTime dataEntrada)
        {
            DMorador Obj = new CamadaDados.DMorador();
            Obj.Nome = nome;
            Obj.Cpf = cpf;
            Obj.Rg = rg;
            Obj.Celular = celular;
            Obj.Email = email;
            Obj.Unidade = unidade;
            Obj.Apto = apto;
            Obj.DataEntrada = dataEntrada;

            return Obj.InserirMorador(Obj);
        }

        //Editar
        public static string EditarMorador(int idMorador, string nome, int cpf, int rg, string celular, string email, string unidade, int apto, DateTime dataEntrada)
        {
            DMorador Obj = new CamadaDados.DMorador();
            Obj.IdMorador = idMorador;
            Obj.Nome = nome;
            Obj.Cpf = cpf;
            Obj.Rg = rg;
            Obj.Celular = celular;
            Obj.Email = email;
            Obj.Unidade = unidade;
            Obj.Apto = apto;
            Obj.DataEntrada = dataEntrada;

            return Obj.EditarMorador(Obj);
        }

        //Excluir
        public static string ExcluirMorador(int idMorador)
        {
            DMorador Obj = new CamadaDados.DMorador();
            Obj.IdMorador = idMorador;
          
            return Obj.ExcluirMorador(Obj);
        }

        //mostrar

        public static DataTable MostrarMoradores()
        {
            return new DMorador().MostrarM();
        }

        //buscar

        public static DataTable BuscarMor(string mostrarNome)
        {
            DMorador Obj = new DMorador();
            Obj.MostrarMorador = mostrarNome;
            return Obj.BuscarMorador(Obj);
        }

    }
}
