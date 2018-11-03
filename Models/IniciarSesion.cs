using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using CINEKONG.Context;

namespace CINEKONG.Models
{
    public class IniciarSesion
    {
        public static int IniciarSesion(string correo, string contraseña)
        {
            int usuarioId = 0;
            CinekongContext dco = new CinekongContext();
            var query = dco.Usuario.Where(p => p.Correo == correo && p.Contraseña == contraseña).Select(p => p);

            var query1 = from p in dco.Usuario where  p.Correo == correo && p.Contraseña == contraseña select p;

            if(query.Count()>0){
                usuarioId = query.First().UsuarioId;
            }
            return usuarioId;
        }
    }

}