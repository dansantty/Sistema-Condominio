using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NVisitante
    {
        //inclui reserva
        public static string InserirVisitante(string nome, int rg)
        {
            DVisitante Obj = new CamadaDados.DVisitante();

            Obj.NomeVisitante = nome;
            Obj.RgVisitante = rg;

            return Obj.IncluirVisitante(Obj);
        }

        // consulta reserva

        public static DataTable ConsultaVisitante(int rg)
        {
            DVisitante Obj = new DVisitante();
            Obj.RgVisitante = rg;
            return Obj.ConsultaVisitante(Obj);
        }

    }
}
