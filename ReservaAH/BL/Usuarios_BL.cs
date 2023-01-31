using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReservaAH.EN;
using ReservaAH.DAL;

namespace ReservaAH.BL
{
    public class Usuarios_BL
    {
        Usuarios_DAL usDal = new Usuarios_DAL();
        public bool Crub_Usuario(Usuarios en)
        {
            return usDal.Crub_Usuario(en);
        }
        public List<Usuarios> Get_Usuarios(string correo)
        {
            return usDal.Get_Usuarios(correo);
        }
        public bool logIn_Usuarios(Usuarios us)
        {
            return usDal.logIn_Usuarios(us);
        }
    }
}