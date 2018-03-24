using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NReserva
    {
        //inclui reserva
        public static string InserirReserva(string area, DateTime data, int idMorador)
        {
            DReserva Obj = new CamadaDados.DReserva();

            Obj.Area = area;
            Obj.Data = data;
            Obj.IdMorador = idMorador;
            

            return Obj.IncluirReserva(Obj);
        }

        // consulta reserva

        public static DataTable ConsultaReserva(int idReserva)
        {
           DReserva Obj = new DReserva();
            Obj.IdReserva = idReserva;
            return Obj.ConsultaReserva(Obj);
        }

        // exclui reserva

        public static string ExcluirReserva(int idReserva)
        {
            DReserva Obj = new CamadaDados.DReserva();
            Obj.IdReserva = idReserva;

            return Obj.ExcluirReserva(Obj);
        }

        public static string InserirReserva(string v1, string v2, int v3)
        {
            throw new NotImplementedException();
        }
    }
}
