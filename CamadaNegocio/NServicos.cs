using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CamadaDados;

namespace CamadaNegocio
{
    public class NServicos
    {
        public static string InseriOs(int idEmpresa, string nomeSolicitante, string tipoServico, string detalhes, DateTime data)
        {
            DServicos Obj = new DServicos();
            Obj.IdEmpresa = idEmpresa;
            Obj.NomeSolicitante = nomeSolicitante;
            Obj.TipoServico = tipoServico;
            Obj.Detalhes = detalhes;
            Obj.Data = data;

            return Obj.InserirOs(Obj);
        }

        public static DataTable ConsultaOs(int idOrdem)
        {
            DServicos Obj = new DServicos();
            Obj.IdOrdem = idOrdem;
            return Obj.ConsultaOs(Obj);
        }

        //Excluir
        public static string EncerrarOs(int idOrdem)
        {
            DServicos Obj = new CamadaDados.DServicos();
            Obj.IdOrdem = idOrdem;

            return Obj.EncerrarOs(Obj);
        }
    }
}
