using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CamadaDados;

namespace CamadaNegocio
{
    public class NGastos
    {
        public static string InserirGastos(int idMorador, decimal gAgua, decimal gLuz, decimal gGas,
            double agua, double luz, double gas, DateTime vencimento)
        {
            DGastos Obj = new CamadaDados.DGastos();
            Obj.IdMorador = idMorador;
            Obj.GAgua = gAgua;
            Obj.GLuz = gLuz;
            Obj.GGas = gGas;
            Obj.Agua = agua;
            Obj.Luz = luz;
            Obj.Gas = gas;
            Obj.Vencimento = vencimento;
         
            return Obj.InserirGastos(Obj);
        }

        public static DataTable EmitirGastos(int cpf)
        {
            DGastos Obj = new DGastos();
            Obj.Cpf = cpf;
            return Obj.EmitirGastos(Obj);
        }
    }
}
