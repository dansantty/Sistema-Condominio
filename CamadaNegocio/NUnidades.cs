using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CamadaDados;

namespace CamadaNegocio
{
   public class NUnidades
    {
        public static string InserirUnidade(string nome, string endereco, int aptos, int aptosDisp, string informacoes)
        {
            DUnidades Obj = new DUnidades();
            Obj.Nome = nome;
            Obj.Endereco = endereco;
            Obj.Aptos = aptos;
            Obj.AptosDisponiveis = aptosDisp;
            Obj.Informacoes = informacoes;

            return Obj.InserirUnidade(Obj);
        }

        public static DataTable BuscarUnidade(int busca)
        {
            DUnidades Obj = new DUnidades();
            Obj.IdUnidade = busca;
            return Obj.BuscarUnidades(Obj);
        }

        public static DataTable ListarUnidades() { 
        
            return new DUnidades().ListarUnidades();
        }


    }
}
