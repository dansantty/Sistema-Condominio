using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
   public class NLogin
    {
        public static string InserirLogin(int idMorador, int cpf, string usuario, string senha, string tipoUsuario)
        {
            DLogin Obj = new CamadaDados.DLogin();
            Obj.IdMorador = idMorador;
            Obj.Cpf = cpf;
            Obj.Usuario = usuario;
            Obj.Senha = senha;
            Obj.TipoUsuario = tipoUsuario;

            return Obj.InserirLogin(Obj);
        }

        public static string AlterarSenha(string usuario, string senha)
        {
            DLogin Obj = new CamadaDados.DLogin();
            Obj.Usuario = usuario;
            Obj.Senha = senha;

            return Obj.AlterarSenha(Obj);
        }

    }
}
