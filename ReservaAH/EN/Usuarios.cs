using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservaAH.EN
{
    public class Usuarios
    {
        public Int64 Id_Usu { get; set; }
        public string Correo_Usu { get; set; }
        public string Contra_Usu { get; set; }
        public string Avatar_Usu { get; set; }
        public int Id_Rol { get; set; }
        public Int32 Opcion { get; set; }
    }
}