using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CamadaDados;

namespace CamadaNegocio
{
   public class NReuniao
    {
        //Agenda Reuniao
        public static string AgendaReuniao(string assunto, string informacoes, string responsavel, DateTime data)
        {
            DReuniao Obj = new DReuniao();
            Obj.Assunto = assunto;
            Obj.Informacoes = informacoes;
            Obj.Responsavel = responsavel;
            Obj.Data = data;

            return Obj.AgendaReuniao(Obj);
        }
        // Consulta Reuniao
        public static DataTable ConsultaReuniao(string assunto)
        {
            DReuniao Obj = new DReuniao();
            Obj.Assunto = assunto;
            return Obj.ConsultaReuniao(Obj);
        }
        // Cancelar Reuniao
        public static string ExcluirReuniao(int idReuniao)
        {
          DReuniao Obj = new CamadaDados.DReuniao();
            Obj.IdReunioes = idReuniao;

            return Obj.CancelarReuniao(Obj);
        }




    }
}
