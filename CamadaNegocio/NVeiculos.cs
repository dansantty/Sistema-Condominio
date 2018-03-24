using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
   public class NVeiculos
    {
        //inserindo Veiculo
        public static string InserirVeiculo(int idMorador, string placa, string nomeVeiculo, int ano)
        {
            DVeiculos Obj = new CamadaDados.DVeiculos();
            Obj.IdMorador = idMorador;
            Obj.Placa = placa;
            Obj.NomeVeiculo = nomeVeiculo;
            Obj.Ano = ano;

            return Obj.InserirVeiculo(Obj);
        }

        public static DataTable BuscarVeiculo(string placa)
        {
            DVeiculos Obj = new DVeiculos();
            Obj.Placa = placa;
            return Obj.BuscarVeiculo(Obj);
        }

        public static string ExcluirVeiculo(int idVeiculo)
        {
            DVeiculos Obj = new CamadaDados.DVeiculos();
            Obj.IdVeiculo = idVeiculo;

            return Obj.ExcluirVeiculo(Obj);
        }
    }
}
